using System.Collections.Generic;
using Abp.AutoMapper;
using LibrarySystem.Books.Dto;
using LibrarySystem.Departments.Dto;
using LibrarySystem.Entities;

namespace LibrarySystem.Borrowers.Dto
{
    [AutoMapTo(typeof(Borrower))]
    public class CreateBorrowerDto
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
