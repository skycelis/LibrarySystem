using Abp.Application.Services;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using LibrarySystem.Borrowers.Dto;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using LibrarySystem.Borrowers;
using LibrarySystem.Entities;

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

        public override Task<PagedResultDto<BorrowerDto>> GetAllAsync(PagedBorrowerResultRequestDto input)
        {
            return base.GetAllAsync(input);
        }

        public override Task<BorrowerDto> GetAsync(EntityDto<int> input)

        {
            return base.GetAsync(input);
        }

        public override Task<BorrowerDto> UpdateAsync(BorrowerDto input)
        {
            return base.UpdateAsync(input);
        }
        public async Task<List<BorrowerDto>> GetAllBorrowers(PagedBorrowerResultRequestDto input)
        {
            var query = await _repository.GetAll()
                .Select(x => ObjectMapper.Map<BorrowerDto>(x))
                .ToListAsync();

            return query;
        }

    }

}
