using Abp.Application.Services;
using Abp.Application.Services.Dto;
using LibrarySystem.Authors.Dto;
using LibrarySystem.Books.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LibrarySystem.Authors
{
    public interface IAuthorAppService : IAsyncCrudAppService<AuthorDto, int, PagedAuthorResultRequestDto, CreateAuthorDto, AuthorDto>
    {
        Task<List<AuthorDto>> GetAllAuthorsUnderBooks(PagedAuthorResultRequestDto input);
        Task<PagedResultDto<AuthorDto>> GetAllAuthors(PagedAuthorResultRequestDto input);
    }

}