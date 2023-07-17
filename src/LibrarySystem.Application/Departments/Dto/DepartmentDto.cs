using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using LibrarySystem.Entities;

namespace LibrarySystem.Departments.Dto
{
    [AutoMapFrom(typeof(Department))]
    [AutoMapTo(typeof(Department))]
    public class DepartmentDto : EntityDto<int>
    {
        public string Name { get; set; }
    }
}
