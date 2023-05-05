using Abp.Application.Services;
using LibrarySystem.Departments.Dto;

namespace LibrarySystem2.Departments
{
    public interface IDepartmentAppService : IAsyncCrudAppService<DepartmentDto, int, PagedDepartmentResultRequestDto, CreateDepartmentDto, DepartmentDto>
    {

    }
}