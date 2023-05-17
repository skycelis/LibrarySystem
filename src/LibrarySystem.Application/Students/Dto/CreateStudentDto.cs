using System.Collections.Generic;
using Abp.AutoMapper;
using LibrarySystem.Departments.Dto;
using LibrarySystem.Entities;

namespace LibrarySystem.Students.Dto
{
    [AutoMapTo(typeof(Student))]
    public class CreateStudentDto
    {
        public int Id { get; set; }
        public string StudentName { get; set; }
        public string StudentContactNumber { get; set; }
        public string StudentEmail { get; set; }
        public int DepartmentId { get; set; }
        public List<DepartmentDto> Departments { get; set; }
    }
}
