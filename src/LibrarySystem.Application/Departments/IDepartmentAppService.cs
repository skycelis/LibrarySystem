using Abp.Application.Services;
using LibrarySystem.Departments.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LibrarySystem.Departments
{
    public interface IDepartmentAppService : IAsyncCrudAppService<DepartmentDto, int, PagedDepartmentResultRequestDto, CreateDepartmentDto, DepartmentDto>
    {
        Task<List<DepartmentDto>> GetAllDepartments();
    }
}