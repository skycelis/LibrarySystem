using Abp.Application.Services;
using LibrarySystem.Borrowers.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Borrowers
{
    public interface IBorrowerAppService :IAsyncCrudAppService<BorrowerDto, int, PagedBorrowerResultRequestDto, CreateBorrowerDto, BorrowerDto>
    {
        Task<List<BorrowerDto>> GetAllBorrowers(PagedBorrowerResultRequestDto input);
    }
}
