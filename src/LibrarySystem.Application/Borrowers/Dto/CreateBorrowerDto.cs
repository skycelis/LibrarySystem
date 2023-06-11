using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Abp.AutoMapper;
using LibrarySystem.Books;
using LibrarySystem.Books.Dto;
using LibrarySystem.Departments.Dto;
using LibrarySystem.Entities;
using LibrarySystem.Students.Dto;
using Microsoft.VisualBasic;

namespace LibrarySystem.Borrowers.Dto
{
    [AutoMapTo(typeof(Borrower))]
    public class CreateBorrowerDto
    {
        [Required]
        public DateTime BorrowDate { get; set; }
        [Required]
        public DateTime ExpectedReturnDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public int? BookId { get; set; }
        public int? StudentId { get; set; }
    }
}
