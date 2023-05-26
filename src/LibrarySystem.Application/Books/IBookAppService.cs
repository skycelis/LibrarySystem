using Abp.Application.Services;
using Abp.Application.Services.Dto;
using LibrarySystem.Books.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LibrarySystem.Books
{
    public interface IBookAppService : IAsyncCrudAppService<BookDto, int, PagedBookResultRequestDto, CreateBookDto, BookDto>
    {
        Task<List<BookDto>> GetAllAuthorsUnderBooks();
        Task<PagedResultDto<BookDto>> GetAllBooksWithCategories(PagedResultRequestDto input);
    }

}