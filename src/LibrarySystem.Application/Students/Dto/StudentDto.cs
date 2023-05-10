using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using LibrarySystem.Authorization.Users;
using LibrarySystem.Departments.Dto;
using LibrarySystem.Entities;

namespace LibrarySystem.Students.Dto
{
    [AutoMapFrom(typeof(StudentDto))]
    [AutoMapTo(typeof(StudentDto))]
    public class StudentDto : EntityDto<int>
    {
        public string StudentName { get; set; }

        public string StudentContactNumber { get; set; }

        public string StudentEmail { get; set; }

        public int DepartmentId { get; set; }
        public DepartmentDto Departments { get; set; }

    }
}
