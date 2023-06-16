using Abp.Application.Services;
using Abp.Application.Services.Dto;
using LibrarySystem.Borrowers.Dto;
using System.Threading.Tasks;

namespace LibrarySystem.Borrowers
{
    public interface IBorrowerAppService :IAsyncCrudAppService<BorrowerDto, int, PagedBorrowerResultRequestDto, CreateBorrowerDto, BorrowerDto>
    {
        Task<PagedResultDto<BorrowerDto>> GetBorrowerWithBooksAndStudent(PagedBorrowerResultRequestDto input);
        Task<BorrowerDto> GetBorrowerWithBook(int id);
    }
}
