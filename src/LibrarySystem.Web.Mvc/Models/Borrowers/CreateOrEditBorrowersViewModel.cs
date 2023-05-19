using LibrarySystem.BookCategories;
using LibrarySystem.Departments.Dto;
using System.Collections.Generic;
using System;

namespace LibrarySystem.Web.Models.Borrowers
{
    public class CreateOrEditBorrowersViewModel
    {
        public DateTime BorrowDate { get; set; }
        public DateTime ExpectedReturnDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public string BookId { get; internal set; }
        public string StudentId { get; internal set; }
        public int Id { get; internal set; }
    }
}
