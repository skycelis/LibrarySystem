using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using LibrarySystem.Controllers;
using Abp.Application.Services.Dto;
using LibrarySystem.Authors;
using LibrarySystem.Books;
using LibrarySystem.Authors.Dto;
using LibrarySystem.Web.Models.Authors;

namespace LibrarySystem.Web.Controllers
{
    public class AuthorsController : LibrarySystemControllerBase
    {
        private IAuthorAppService _authorappService;
        private IBookAppService _bookappService;
        public AuthorsController(IAuthorAppService authorappService, IBookAppService bookappService)
        {
            _authorappService = authorappService;
            _bookappService = bookappService;
        }

        public async Task<IActionResult> Index()
        {
            var authors = await _authorappService.GetAllAuthorsUnderBooks(new PagedAuthorResultRequestDto { MaxResultCount = int.MaxValue });
            var model = new AuthorViewModel()
            {
                Authors = authors.Items.ToList()
            };

            return View(model);
        }


        [HttpGet]


        public async Task<IActionResult> CreateAuthor(int id)
        {
            var model = new CreateOrEditAuthorViewModel();
            var books = await _bookappService.GetAllBooks();

            if (id != 0)
            {
                var authors = await _authorappService.GetAsync(new EntityDto<int>(id));
                model = new CreateOrEditAuthorViewModel()
                {
                    Name = authors.Name,
                    BookId = authors.BookId,
                    Id = id

                };
            }

            model.ListBooks = books;
            return View(model);
        }

    }
}
