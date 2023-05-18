using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using LibrarySystem.BookCategories;

namespace LibrarySystem.Books
{
    [AutoMapFrom(typeof(BookDto))]
    [AutoMapTo(typeof(BookDto))]

    public class BookDto : EntityDto<int>
    {
        public string BookTitle { get; set; }
        public string BookPublisher { get; set; }
        public string BookAuthor { get; set; }
        public bool IsBorrowed { get; set; }
        public int BookCategoryId { get; set; }
        public BookCategoryDto BookCategories { get; set; }

    }
}
