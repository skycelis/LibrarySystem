using LibrarySystem.Departments.Dto;
using System.Collections.Generic;

namespace LibrarySystem.Web.Models.Students
{
    public class CreateOrEditStudentViewModel
    {
        public int Id { get; set; }
        public string StudentName { get; set; }

        public string StudentContactNumber { get; set; }

        public string StudentEmail { get; set; }

        public int DepartmentId { get; set; }
        public List<DepartmentDto> Departments { get; set; }
    }
}
