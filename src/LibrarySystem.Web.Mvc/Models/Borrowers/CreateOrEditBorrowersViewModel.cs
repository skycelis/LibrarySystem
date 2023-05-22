using LibrarySystem.BookCategories;
using LibrarySystem.Departments.Dto;
using System.Collections.Generic;
using System;
using LibrarySystem.Books;
using LibrarySystem.Students.Dto;
using System.ComponentModel.DataAnnotations;

namespace LibrarySystem.Web.Models.Borrowers
{
    public class CreateOrEditBorrowersViewModel
    {
        public DateTime BorrowDate { get; set; }
        public DateTime ExpectedReturnDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public string BookId { get; set; }
        public string StudentId { get; set; }
        public int Id { get; internal set; }
        [Required]
        public bool IsBorrowed { get; set; }
        public List<BookDto> Books { get; set; }
        public List<StudentDto> Students { get; set;}
    }
}
