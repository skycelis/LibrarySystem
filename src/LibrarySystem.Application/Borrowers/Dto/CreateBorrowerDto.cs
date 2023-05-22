using System;
using System.Collections.Generic;
using Abp.AutoMapper;
using LibrarySystem.Books.Dto;
using LibrarySystem.Departments.Dto;
using LibrarySystem.Entities;
using Microsoft.VisualBasic;

namespace LibrarySystem.Borrowers.Dto
{
    [AutoMapTo(typeof(Borrower))]
    public class CreateBorrowerDto
    {
        public DateTime BorrowDate { get; set; }
        public DateTime ExpectedReturnDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public string BookId { get; set; }
        public string StudentId { get; set; }
        public Book Book { get; set; }
        public Student Student { get; set; }
    }
}
