using Abp.Application.Services;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using LibrarySystem.BookCategories.Dto;
using LibrarySystem.Entities;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace LibrarySystem.BookCategories
{
    public class BookAppService : AsyncCrudAppService<Book, BookCategoryDto, int, PagedBookCategoryResultRequestDto, CreateBookCategoryDto, BookCategoryDto>, IBookAppService

    {
        private IRepository<Book, int> _repository;
        public BookAppService(IRepository<Book, int> repository) : base(repository)
        {
            _repository = repository;
        }

        public override Task<BookCategoryDto> CreateAsync(CreateBookCategoryDto input)
        {
            return base.CreateAsync(input);
        }

        public override Task DeleteAsync(EntityDto<int> input)
        {
            return base.DeleteAsync(input);
        }

        public override Task<PagedResultDto<BookCategoryDto>> GetAllAsync(PagedBookCategoryResultRequestDto input)
        {
            return base.GetAllAsync(input);
        }

        public override Task<BookCategoryDto> GetAsync(EntityDto<int> input)

        {
            return base.GetAsync(input);
        }

        public override Task<BookCategoryDto> UpdateAsync(BookCategoryDto input)
        {
            return base.UpdateAsync(input);
        }

        public async Task<List<BookCategoryDto>> GetAllBooks()
        {
            var query = await _repository.GetAll()
                .Select(x => ObjectMapper.Map<BookCategoryDto>(x))
                .ToListAsync();

            return query;
        }

    }

}
