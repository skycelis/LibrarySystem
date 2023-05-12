using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using LibrarySystem.Students;
using LibrarySystem.Students.Dto;
using LibrarySystem.Entities;

namespace LibrarySystem.Students
{
    public class StudentAppService : AsyncCrudAppService<Student, StudentDto, int, PagedStudentResultRequestDto, CreateStudentDto, StudentDto>, IStudentAppService
    {
        private IRepository<Student, int> repository;
        private readonly object _repository;

        public StudentAppService(IRepository<Student, int> repository) : base(repository)
        {
            repository = repository;
        }

        

        public override Task DeleteAsync(EntityDto<int> input)
        {
            return base.DeleteAsync(input);
        }

        public override Task<PagedResultDto<StudentDto>> GetAllAsync(PagedStudentResultRequestDto input)
        {
            return base.GetAllAsync(input);
        }

        public override Task<StudentDto> GetAsync(EntityDto<int> input)
        {
            return base.GetAsync(input);
        }

        public override Task<StudentDto> UpdateAsync(StudentDto input)
        {
            return base.UpdateAsync(input);
        }

        protected override Task<Student> GetEntityByIdAsync(int id)
        {
            return base.GetEntityByIdAsync(id);
        }

        public override Task<StudentDto> CreateAsync(CreateStudentDto input)
        {
            return base.CreateAsync(input);
        }
    }
}
