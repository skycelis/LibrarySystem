using LibrarySystem.Departments.Dto;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using LibrarySystem.Departments;
using LibrarySystem.Web.Models.Departments;
using LibrarySystem.Controllers;
using System;
using Abp.Application.Services.Dto;
using Castle.DynamicProxy.Generators.Emitters.SimpleAST;

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

            return View(model);
        }

        //private IActionResult ViewComponent(DepartmentListViewModel model)
        //{
        //    throw new NotImplementedException();
        //}

        [HttpGet]

        //public ActionResult CreateDepartment(int id)
        //{
        //    var model = new CreateOrEditDepartmentWiewModel();

        //    return View();
        //}

        public async Task<IActionResult> CreateDepartment(int id)
        {
            var model = new CreateOrEditDepartmentViewModel();

            if (id > 0)
            {
                var department = await _departmentappService.GetAsync(new EntityDto<int>(id));
                model = new CreateOrEditDepartmentViewModel()
                {
                    Name = department.Name,
                    Id = id
                };
            }

        return View(model);
        }

    }
}
