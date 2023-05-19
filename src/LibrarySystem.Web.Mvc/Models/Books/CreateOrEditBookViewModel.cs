using LibrarySystem.BookCategories;
using System.Collections.Generic;

namespace LibrarySystem.Web.Models.Books
{
    public class CreateOrEditBookViewModel
    {
        public string BookTitle { get; set; }
        public string BookPublisher { get; set; }
        public string BookAuthor { get; set; }
        public bool IsBorrowed { get; set; }
        public List<BookCategoryDto> ListBookCategories { get; set; }
        public string BookCategoryId { get; internal set; }
        public int Id { get; internal set; }
    }
}
