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
        public string ExpectedReturnDate { get; set; }
        public string ReturnDate { get; set; }
        public string BookId { get; set; }
        public string StudentId { get; set; }
        public BookCategory Book { get; set; }
        public Student Student { get; set; }
    }
}
