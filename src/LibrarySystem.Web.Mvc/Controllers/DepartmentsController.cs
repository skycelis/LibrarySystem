using LibrarySystem.Departments.Dto;
using LibrarySystem.Web.Models.Departments;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using LibrarySystem2.Departments;
using LibrarySystem.Controllers;
using System;

namespace LibrarySystem.Web.Controllers
{
    public class DepartmentsController : LibrarySystemControllerBase
    {
        private readonly IDepartmentAppService _departmentappService;

        public DepartmentsController(IDepartmentAppService departmentappService)
        {
            _departmentappService = departmentappService;
        }

        public async Task<IActionResult> Index()
        {
            var departments = await _departmentappService.GetAllAsync(new PagedDepartmentResultRequestDto { MaxResultCount = int.MaxValue });
            var model = new DepartmentListViewModel()
            {
                Departments = departments.Items.ToList()
            };

            return ViewComponent(model);
        }

        private IActionResult ViewComponent(DepartmentListViewModel model)
        {
            throw new NotImplementedException();
        }

        [HttpGet]

        public ActionResult CreateDepartment(int id)
        {
            var model = new CreateOrEditDepartmentWiewModel();

            return View();
        }

        public ActionResult EditDepartment()
        {
            var model = new CreateOrEditDepartmentViewModel();

            return View();
        }

    }
}
