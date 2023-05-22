using System.Collections.Generic;
using Abp.AutoMapper;
using LibrarySystem.BookCategories;
using LibrarySystem.Entities;

namespace LibrarySystem.Books.Dto
{
    [AutoMapTo(typeof(Book))]
    public class CreateBookDto
    {
        public string BookTitle { get; set; }
        public string BookPublisher { get; set; }
        public string BookAuthor { get; set; }
        public bool IsBorrowed { get; set; }
        public int BookCategory { get; set; }
        public List<BookCategoryDto> BookCategories { get; set; }
    }
}
