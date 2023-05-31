using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using LibrarySystem.Authorization.Users;
using LibrarySystem.Books;
using LibrarySystem.Departments.Dto;
using LibrarySystem.Entities;
using LibrarySystem.Students.Dto;
using Microsoft.VisualBasic;
using System;

namespace LibrarySystem.Borrowers.Dto
{
    [AutoMapTo(typeof(Borrower))]
    [AutoMapFrom(typeof(Borrower))]
    
    public class BorrowerDto : EntityDto<int>
    {
        public DateTime BorrowDate { get; set; }
        public DateTime ExpectedReturnDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public int BookId { get; set; }
        public BookDto Book { get; set; }
        public int StudentId { get; set; }        
        public StudentDto Student { get; set; }

    }
}
