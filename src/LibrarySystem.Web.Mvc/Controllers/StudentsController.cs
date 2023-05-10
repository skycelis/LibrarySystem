using LibrarySystem.Departments.Dto;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using LibrarySystem.Departments;
using LibrarySystem.Web.Models.Departments;
using LibrarySystem.Controllers;
using System;
using Abp.Application.Services.Dto;
using LibrarySystem.Students;
using LibrarySystem.Students.Dto;
using LibrarySystem.Users.Dto;
using LibrarySystem.Web.Models.Students;

namespace LibrarySystem.Web.Controllers
{
    public class StudentsController : LibrarySystemControllerBase
    {
        private IStudentAppService _studentappService;
        private IDepartmentAppService _departmentappService;
        private object await_departmentAppService;

        public StudentsController(IStudentAppService studentappService, IDepartmentAppService departmentappService)
        {
            _studentappService = studentappService;
            _departmentappService = departmentappService;
        }

        public async Task<IActionResult> Index()
        {
            var students = await _studentappService.GetAllAsync(new PagedStudentResultRequestDto { MaxResultCount = int.MaxValue });
            var model = new StudentListViewModel()
            {
                Students = students.Items.ToList()
            };


            return View(model);
        }

        //private IActionResult ViewComponent(DepartmentListViewModel model)
        //{
        //    throw new NotImplementedException();
        //}

        [HttpGet]


        public async Task<IActionResult> CreateOrEdit(int id)
        {
            var model = new CreateOrEditStudentViewModel();
            var departments = await _departmentappService.GetAllDepartments();

            if (id != 0)
            {
                var student = await _studentappService.GetAsync(new EntityDto<int>(id));
                model = new CreateOrEditStudentViewModel()
                {
                    StudentName = student.StudentName,
                    StudentContactNumber = student.StudentContactNumber,
                    StudentEmail = student.StudentEmail,
                    DepartmentId = student.DepartmentId,
                    Id = id

                };
            }

            model.Departments = departments;   
            return View(model);
        }

    }
}
