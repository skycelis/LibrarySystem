using Abp.Application.Services;
using Abp.Application.Services.Dto;
using LibrarySystem.Students.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LibrarySystem.Students
{
    public interface IStudentAppService : IAsyncCrudAppService<StudentDto, int, PagedStudentResultRequestDto, CreateStudentDto, StudentDto>
    {
        Task<PagedResultDto<StudentDto>> GetAllStudentsWithDepartment(PagedStudentResultRequestDto input);
        Task<List<StudentDto>> GetAllStudents();
    }

}