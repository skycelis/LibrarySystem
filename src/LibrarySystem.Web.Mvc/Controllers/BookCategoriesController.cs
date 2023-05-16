using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using LibrarySystem.Departments;
using LibrarySystem.Controllers;
using Abp.Application.Services.Dto;
using LibrarySystem.BookCategories;
using LibrarySystem.BookCategories.Dto;
using LibrarySystem.Web.Models.BookCategories;

namespace LibrarySystem.Web.Controllers
{
    public class BookCategoriesController : LibrarySystemControllerBase
    {
        private IBookCategoryAppService _bookcategoryappService;
        private IDepartmentAppService _departmentappService;
        private object await_departmentAppService;

        public BookCategoriesController(IBookCategoryAppService bookcategoryappService, IDepartmentAppService departmentappService)
        {
            _bookcategoryappService = bookcategoryappService;
            _departmentappService = departmentappService;
        }

        public async Task<IActionResult> Index()
        {
            var bookcategories = await _bookcategoryappService.GetAllAsync(new PagedBookCategoryResultRequestDto { MaxResultCount = int.MaxValue });
            var model = new BookCategoryListViewModel()
            {
                BookCategories = bookcategories.Items.ToList()
            };

            return View(model);
        }


        [HttpGet]


        public async Task<IActionResult> CreateBookCategory(int id)
        {
            var model = new CreateOrEditBookCategoryListViewModel();
            var departments = await _departmentappService.GetAllDepartments();

            if (id != 0)
            {
                var bookcategory = await _bookcategoryappService.GetAsync(new EntityDto<int>(id));
                model = new CreateOrEditBookCategoryListViewModel()
                {
                    Name = bookcategory.Name,
                    Id = id

                };
            }

            model.ListDepartments = departments;
            return View(model);
        }

    }
}
