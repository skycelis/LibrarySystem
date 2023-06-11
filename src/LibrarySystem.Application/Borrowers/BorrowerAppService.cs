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

        public BorrowerAppService(IRepository<Borrower, int> repository) : base(repository)
        {
            _repository = repository;
        }

        public override Task<BorrowerDto> CreateAsync(CreateBorrowerDto input)
        {
            return base.CreateAsync(input);
        }
        public override Task DeleteAsync(EntityDto<int> input)
        {
            return base.DeleteAsync(input);
        }

        public override Task<BorrowerDto> UpdateAsync(BorrowerDto input)
        {
            return base.UpdateAsync(input);
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
                .Select(x => ObjectMapper.Map<BorrowerDto>(x))
                .ToListAsync();

            return new PagedResultDto<BorrowerDto>(borrower.Count(), borrower);
        }


        //public async Task<List<BorrowerDto>> GetAllBorrowers(PagedBorrowerResultRequestDto input)
        //{
        //    var query = await _repository.GetAll()
        //        .Select(x => ObjectMapper.Map<BorrowerDto>(x))
        //        .ToListAsync();

        //    return query;
        //}
        //public async Task<List<BorrowerDto>> GetAllStudentsWithBorrowers()
        //{
        //    var borrower = await _repository.GetAll()
        //        .Select(x => ObjectMapper.Map<BorrowerDto>(x))
        //        .ToListAsync();

        //    return borrower;
        //}
        //public async Task<List<BorrowerDto>> GetAllBooksWithBorrowers()
        //{
        //    var borrower = await _repository.GetAll()
        //        .Include(x => x.Book)
        //        .Select(x => ObjectMapper.Map<BorrowerDto>(x))
        //        .ToListAsync();

        //    return borrower;
        //}
        //public override async Task<PagedResultDto<BorrowerDto>> GetAllAsync(PagedBorrowerResultRequestDto input)
        //{
        //    var borrowers = await _repository.GetAll()
        //        .Include(x => x.Book)
        //            .ThenInclude(x => x.BookCategory)
        //            .ThenInclude(x => x.Department)
        //        .Include(x => x.Student)
        //            .ThenInclude(x => x.Department)
        //        .OrderByDescending(x => x.Id)
        //        .Select(x => ObjectMapper.Map<BorrowerDto>(x))
        //        .ToListAsync();

        //    return new PagedResultDto<BorrowerDto>(borrowers.Count(), borrowers);
        //    return base.GetAllAsync(input);
        //}
    }

}
