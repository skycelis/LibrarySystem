using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using LibrarySystem.Authors.Dto;
using LibrarySystem.Entities;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace LibrarySystem.Authors
{
    public class AuthorAppService : AsyncCrudAppService<Author, AuthorDto, int, PagedAuthorResultRequestDto, CreateAuthorDto, AuthorDto>, IAuthorAppService
    {
        private IRepository<Author, int> _repository;
        //private Task<PagedResultDto<StudentDto>> query;
        //private readonly object repository;

        public AuthorAppService(IRepository<Author, int> repository) : base(repository)
        {
            _repository = repository;
        }

        public override Task DeleteAsync(EntityDto<int> input)
        {
            return base.DeleteAsync(input);
        }

        public override Task<PagedResultDto<AuthorDto>> GetAllAsync(PagedAuthorResultRequestDto input)
        {
            return base.GetAllAsync(input);
        }

        public override Task<AuthorDto> GetAsync(EntityDto<int> input)
        {
            return base.GetAsync(input);
        }

        public override Task<AuthorDto> UpdateAsync(AuthorDto input)
        {
            return base.UpdateAsync(input);
        }

        protected override Task<Author> GetEntityByIdAsync(int id)
        {
            return base.GetEntityByIdAsync(id);
        }

        public override Task<AuthorDto> CreateAsync(CreateAuthorDto input)
        {
            return base.CreateAsync(input);
        }

        public async Task<PagedResultDto<AuthorDto>> GetAllAuthorsUnderBooks(PagedAuthorResultRequestDto input)
        {
            var authors = await _repository.GetAll()
                .Select(x => ObjectMapper.Map<AuthorDto>(x))
                .ToListAsync();

            return new PagedResultDto<AuthorDto>(authors.Count(), authors);
        }
    }
}

