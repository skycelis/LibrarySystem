using Abp.Application.Services;
using Abp.Application.Services.Dto;
using LibrarySystem.Books;
using LibrarySystem.Borrowers.Dto;
using LibrarySystem.Students.Dto;
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
        Task<List<BorrowerDto>> GetAllStudentsWithBorrowers();
        Task<List<BorrowerDto>> GetAllBooksWithBorrowers();
        Task<BorrowerDto> GetBorrowerWithBooksAndStudent(EntityDto<int> input);
    }
}
