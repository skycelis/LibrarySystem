using Abp.Application.Services;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using LibrarySystem.Departments.Dto;
using LibrarySystem.Entities;

namespace LibrarySystem2.Departments
{
    public class DepartmentAppService : AsyncCrudAppService<Department, DepartmentDto, int, PagedDepartmentResultRequestDto, CreateDepartmentDto, DepartmentDto>, IDepartmentAppService

    {
        public DepartmentAppService(IRepository<Department, int> repository) : base(repository)
        {
        }

        public override Task<DepartmentDto> CreateAsync(CreateDepartmentDto input)
        {
            return base.CreateAsync(input);
        }

        public override Task DeleteAsync(EntityDto<int> input)
        {
            return base.DeleteAsync(input);
        }


#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override Task<PagedResultDto<DepartmentDto>> GetAllAsync(PagedDepartmentResultRequestDto input)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            return base.GetAllAsync(input);
        }


#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override Task<DepartmentDto> GetAsync(EntityDto<int> input)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            return base.GetAsync(input);
        }
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override Task<DepartmentDto> UpdateAsync(DepartmentDto input)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            return base.UpdateAsync(input);
        }
    }

}
