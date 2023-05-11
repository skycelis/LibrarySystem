using Abp.Application.Services;
using LibrarySystem.Students.Dto;
using System.Threading.Tasks;

namespace LibrarySystem.Students
{
    public interface IStudentAppService : IAsyncCrudAppService<StudentDto, int, PagedStudentResultRequestDto, CreateStudentDto, StudentDto>
    {
        Task<StudentDto> CreateAsync(CreateStudentDto input);
    }
}