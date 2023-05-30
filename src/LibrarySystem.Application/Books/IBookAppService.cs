using Abp.Application.Services;
using Abp.Application.Services.Dto;
using LibrarySystem.Books.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Collections.Generic;
using LibrarySystem.Departments.Dto;

namespace LibrarySystem.Books
{
    public interface IBookAppService : IAsyncCrudAppService<BookDto, int, PagedBookResultRequestDto, CreateBookDto, BookDto>
    {
        Task<PagedResultDto<BookDto>> GetAllBooksWithCategories(PagedResultRequestDto input);

        Task<List<BookDto>> GetAllAuthorsUnderBooks();
        Task<List<BookDto>> GetAllBooks();


    }

}