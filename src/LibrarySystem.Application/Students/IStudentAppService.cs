using Abp.Application.Services;
using LibrarySystem.Students.Dto;

namespace LibrarySystem.Students
{
    public interface IStudentAppService : IAsyncCrudAppService<StudentDto, int, PagedStudentResultRequestDto, CreateStudentDto, StudentDto>
    {
    }
}