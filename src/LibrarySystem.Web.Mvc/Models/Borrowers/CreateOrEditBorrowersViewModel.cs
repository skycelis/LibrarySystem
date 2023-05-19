using LibrarySystem.BookCategories;
using LibrarySystem.Departments.Dto;
using System.Collections.Generic;

namespace LibrarySystem.Web.Models.Borrowers
{
    public class CreateOrEditBorrowersViewModel
    {
        public object BorrowDate { get; set; }
        public int ExpectedReturnDate { get; set; }
        public int ReturnDate { get; set; }
        public string BookId { get; internal set; }
        public string StudentId { get; internal set; }
        public int Id { get; internal set; }
    }
}
