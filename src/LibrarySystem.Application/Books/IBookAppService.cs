using Abp.Application.Services;
using Abp.Application.Services.Dto;
using LibrarySystem.Books.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;
using LibrarySystem.Departments.Dto;
using LibrarySystem.Authors.Dto;
using LibrarySystem.Authors;

namespace LibrarySystem.Books
{
    public interface IBookAppService : IAsyncCrudAppService<BookDto, int, PagedBookResultRequestDto, CreateBookDto, BookDto>
    {
        Task<PagedResultDto<BookDto>> GetAllBooksWithCategoriesAndAuthor(PagedBookResultRequestDto input);
        Task<List<BookDto>> GetAllBooks();
        Task<List<BookDto>> GetAllAuthorsUnderBooks();
        Task<PagedResultDto<AuthorDto>> GetAllAuthors(PagedAuthorResultRequestDto input);

    }

}