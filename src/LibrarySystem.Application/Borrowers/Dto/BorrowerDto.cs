using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using LibrarySystem.Authorization.Users;
using LibrarySystem.Departments.Dto;
using LibrarySystem.Entities;

namespace LibrarySystem.Borrowers.Dto
{
    [AutoMapFrom(typeof(Borrower))]
    [AutoMapTo(typeof(Borrower))]
    public class BorrowerDto : EntityDto<int>
    {
        public object BorrowDate { get; set; }
        public int? ExpectedReturnDate { get; set; }
        public int? ReturnDate { get; set; }
        public int? BookId { get; set; }
        public int StudentId { get; set; }
        public BookCategory Book { get; set; }
        public Student Student { get; set; }

    }
}
