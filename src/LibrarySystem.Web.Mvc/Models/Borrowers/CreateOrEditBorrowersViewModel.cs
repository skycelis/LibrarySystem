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
        public int Id { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime ExpectedReturnDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        [Required]
        public bool IsBorrowed { get; set; }
        [Required]
        public int? BookId { get; set; }
        public List<BookDto> Books { get; set; }

        [Required]
        public int? StudentId { get; set; }
        public List<StudentDto> Students { get; set;}
    }
}
