using Abp.Application.Services;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using LibrarySystem.Borrowers.Dto;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using LibrarySystem.Entities;
using LibrarySystem.Students.Dto;
using LibrarySystem.Books;

namespace LibrarySystem.Borrowers
{
    public class BorrowerAppService : AsyncCrudAppService<Borrower, BorrowerDto, int, PagedBorrowerResultRequestDto, CreateBorrowerDto, BorrowerDto>, IBorrowerAppService

    {
        private readonly IRepository<Borrower, int> _repository;
        private readonly IRepository<Book, int> _bookRepository;

        public BorrowerAppService(IRepository<Borrower, int> repository, IRepository<Book, int> bookrepository) : base(repository)
        {
            _repository = repository;
            _bookRepository = bookrepository;
        }

        public override async Task<BorrowerDto> CreateAsync(CreateBorrowerDto input)
        {
            var borrower = ObjectMapper.Map<Borrower>(input);
            await _repository.InsertAsync(borrower);

            var book = await _bookRepository.GetAsync(input.BookId);

            book.IsBorrowed = true;

            await _bookRepository.UpdateAsync(book);

            return base.MapToEntityDto(borrower);
        }
        public override Task DeleteAsync(EntityDto<int> input)
        {
            return base.DeleteAsync(input);
        }

        public override async Task<BorrowerDto> UpdateAsync(BorrowerDto input)
        {
            var borrower = ObjectMapper.Map<Borrower>(input);
            await _repository.UpdateAsync(borrower);

            var book = await _bookRepository.GetAsync(input.BookId);
            
            if(borrower.ReturnDate.HasValue) {
                book.IsBorrowed = false;
            }

            await _bookRepository.UpdateAsync(book);

            return base.MapToEntityDto(borrower);
        }
        public override Task<BorrowerDto> GetAsync(EntityDto<int> input)
        {
            return base.GetAsync(input);
        }
        public override Task<PagedResultDto<BorrowerDto>> GetAllAsync(PagedBorrowerResultRequestDto input)
        {
            return base.GetAllAsync(input);
        }

        protected override Task<Borrower> GetEntityByIdAsync(int id)
        {
            return base.GetEntityByIdAsync(id);
        }

        public async Task<PagedResultDto<BorrowerDto>> GetBorrowerWithBooksAndStudent(PagedBorrowerResultRequestDto input)

        {
            var borrower = await _repository.GetAll()
                .Include(x => x.Book)
                .Include(x => x.Student)
                .OrderByDescending(x => x.Id)
                .Select(x => ObjectMapper.Map<BorrowerDto>(x))
                .ToListAsync();

            return new PagedResultDto<BorrowerDto>(borrower.Count(), borrower);
        }
    }

}
