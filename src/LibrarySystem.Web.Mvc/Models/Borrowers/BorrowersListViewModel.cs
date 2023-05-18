using LibrarySystem.Borrowers;
using LibrarySystem.Borrowers.Dto;
using LibrarySystem.Departments.Dto;
using System.Collections.Generic;

namespace LibrarySystem.Web.Models.Borrowers
{
    public class BorrowersListViewModel
    {
        public List<BorrowerDto> Borrowers { get; set; }
    }
}
