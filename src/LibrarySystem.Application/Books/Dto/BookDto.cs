using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using LibrarySystem.Authors;
using LibrarySystem.BookCategories;
using LibrarySystem.Entities;

namespace LibrarySystem.Books
{
    [AutoMapFrom(typeof(Book))]
    [AutoMapTo(typeof(Book))]

    public class BookDto : EntityDto<int>
    {
        public string BookTitle { get; set; }
        public string BookPublisher { get; set; }
        public bool IsBorrowed { get; set; }
        public int BookCategoryId { get; set; }        
        public BookCategoryDto BookCategory { get; set; }
        public int AuthorId { get; set; }
        public AuthorDto Author { get; set; }

    }
}
