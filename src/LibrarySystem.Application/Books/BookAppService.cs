using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using LibrarySystem.Books.Dto;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using LibrarySystem.Books;
using LibrarySystem.BookCategories.Dto;
using LibrarySystem.BookCategories;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace LibrarySystem.Entities.Books
{
    public class BookAppService : AsyncCrudAppService<Book, BookDto, int, PagedBookResultRequestDto, CreateBookDto, BookDto>, IBookAppService
    {
        private readonly IRepository<Book, int> _repository;
       
        public BookAppService(IRepository<Book, int> repository) : base(repository)
        {
            _repository = repository;
        }

        public override Task DeleteAsync(EntityDto<int> input)
        {
            return base.DeleteAsync(input);
        }

        public override Task<PagedResultDto<BookDto>> GetAllAsync(PagedBookResultRequestDto input)
        {
            return base.GetAllAsync(input);
        }

        public override Task<BookDto> GetAsync(EntityDto<int> input)
        {
            return base.GetAsync(input);
        }

        public override Task<BookDto> UpdateAsync(BookDto input)
        {
            return base.UpdateAsync(input);
        }

        protected override Task<Book> GetEntityByIdAsync(int id)
        {
            return base.GetEntityByIdAsync(id);
        }

        public override Task<BookDto> CreateAsync(CreateBookDto input)
        {
            return base.CreateAsync(input);
        }
        public async Task<List<BookDto>> GetAllBooks()
        {
            var books = await _repository.GetAll()
            .Select(x => ObjectMapper.Map<BookDto>(x))
            .ToListAsync();
            return books;
        }
        public async Task<PagedResultDto<BookDto>> GetAllBooksWithCategories(PagedResultRequestDto input)
        {
            var books = await _repository.GetAll()
                .Include(x => x.BookCategory)
                .Select(x => ObjectMapper.Map<BookDto>(x))
                .ToListAsync();

            return new PagedResultDto<BookDto>(books.Count(), books);
        }
        public async Task<List<BookDto>> GetAllAuthorsUnderBooks()
        {
            var books = await _repository.GetAll()
                .Include(x => x.BookCategory)
                .Select(x => ObjectMapper.Map<BookDto>(x))
                .ToListAsync();

            return books;
        }

    }
}

