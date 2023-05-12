using Abp.Application.Services;
using Abp.Application.Services.Dto;
using LibrarySystem.Students.Dto;
using System.Threading.Tasks;

namespace LibrarySystem.Students
{
    public interface IStudentAppService : IAsyncCrudAppService<StudentDto, int, PagedStudentResultRequestDto, CreateStudentDto, StudentDto>
    {
        //Task<PagedResultDto<StudentDto>> GetAllStudentsWithDepartment(PagedResultRequestDto input);
    }
}