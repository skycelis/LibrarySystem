using Abp.Application.Services;
using LibrarySystem.BookCategories.Dto;
using LibrarySystem.Departments.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LibrarySystem.BookCategories
{
    public interface IBookAppService : IAsyncCrudAppService<BookCategoryDto, int, PagedBookCategoryResultRequestDto, CreateBookCategoryDto, BookCategoryDto>
    {
        Task<List<BookCategoryDto>> GetAllBooks();
    }
}