using LibrarySystem.Authors;
using LibrarySystem.Books;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using LibrarySystem.Controllers;
using Abp.Application.Services.Dto;
using LibrarySystem.Authors;
using LibrarySystem.Books;
using LibrarySystem.Authors.Dto;
using LibrarySystem.Web.Models.Authors;
using LibrarySystem.Web.Models.Authors;
using LibrarySystem.Web.Models.Students;
using LibrarySystem.Authors.Dto;

namespace LibrarySystem.Web.Controllers
{
    public class AuthorsController : LibrarySystemControllerBase
    {
        private IAuthorAppService _authorappService;
        public AuthorsController(IAuthorAppService userAppService)
        {
            _authorappService = userAppService;
        }

        public async Task<IActionResult> Index()
        {
            var authors = await _authorappService.GetAllAuthorsUnderBooks();
            var model = new AuthorViewModel()
            {
                Authors = authors
            };
            return View(model);
        }


        [HttpGet]


        public async Task<IActionResult> CreateAuthor(int id)
        {

            if (id != 0)
            {
                var authors = await _authorappService.GetAsync(new EntityDto<int>(id));
                var model = new CreateOrEditAuthorViewModel()
                {
                    Name = authors.Name,
                    Id = id
                };
                return View(model);
            }
            else
            {
                return View();
            }
           

        }
    }
}

