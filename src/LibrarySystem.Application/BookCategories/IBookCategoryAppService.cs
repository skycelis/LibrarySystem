using Abp.Application.Services;
using Abp.Application.Services.Dto;
using LibrarySystem.BookCategories.Dto;
using LibrarySystem.Departments.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LibrarySystem.BookCategories
{
    public interface IBookCategoryAppService : IAsyncCrudAppService<BookCategoryDto, int, PagedBookCategoryResultRequestDto, CreateBookCategoryDto, BookCategoryDto>
    {
        Task<PagedResultDto<BookCategoryDto>> GetAllBookCategoriesWithDepartments(PagedBookCategoryResultRequestDto input);
        Task<List<BookCategoryDto>> GetAllBookCategories();

    }
}