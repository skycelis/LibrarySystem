using LibrarySystem.BookCategories;
using LibrarySystem.Entities;
using System.Collections.Generic;

namespace LibrarySystem.Web.Models.Books
{
    public class CreateOrEditBookViewModel
    {
        public int Id { get; set; }
        public string BookTitle { get; set; }
        public string BookPublisher { get; set; }
        public string BookAuthor { get; set; }
        public bool IsBorrowed { get; set; }
        public int? BookCategoryId { get; set; }
        public List<BookCategoryDto> ListBookCategories { get; set; }        
       
    }
}
