using Abp.Application.Services;
using Abp.Application.Services.Dto;
using LibrarySystem.Books.Dto;
using LibrarySystem.Students.Dto;
using System.Threading.Tasks;

namespace LibrarySystem.Books
{
    public interface IBookAppService : IAsyncCrudAppService<BookDto, int, PagedBookResultRequestDto, CreateBookDto, BookDto>
    {
        Task<PagedResultDto<BookDto>> GetAllBookWithCategory(PagedBookResultRequestDto input);
    }

}