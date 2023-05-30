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
<<<<<<< HEAD
        Task<PagedResultDto<BookDto>> GetAllBookWithCategory(PagedBookResultRequestDto input);
        Task<List<BookDto>> GetAllBooks();
=======
        Task<List<BookDto>> GetAllAuthorsUnderBooks();
        Task<PagedResultDto<BookDto>> GetAllBooksWithCategories(PagedResultRequestDto input);
>>>>>>> 80d52e39396ba3c78fb4a4a9ac8f79193bf2a815
    }

}