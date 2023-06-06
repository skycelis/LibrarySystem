using LibrarySystem.Authors;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using LibrarySystem.Controllers;
using Abp.Application.Services.Dto;
using LibrarySystem.Web.Models.Authors;
using LibrarySystem.Books.Dto;
using LibrarySystem.Authors.Dto;
using System.Linq;

namespace LibrarySystem.Web.Controllers
{
    public class AuthorsController : LibrarySystemControllerBase
    {
        private IAuthorAppService _authorappService;
        public AuthorsController(IAuthorAppService userAppService)
        {
            _authorappService = userAppService;
        }

        public async Task<IActionResult> Index(string SearchAuthor)
        {
            var authors = await _authorappService.GetAllAuthorsUnderBooks(new PagedAuthorResultRequestDto { MaxResultCount = int.MaxValue });
            var model = new AuthorViewModel();

            if (!string.IsNullOrEmpty(SearchAuthor))
            {
                model = new AuthorViewModel()
                {
                    Authors = authors.ToList().Where(x => x.Name.Contains(SearchAuthor)).ToList()
                };
            }
            else
            {
                model = new AuthorViewModel()
                {
                    Authors = authors.ToList()
                };
            }

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

