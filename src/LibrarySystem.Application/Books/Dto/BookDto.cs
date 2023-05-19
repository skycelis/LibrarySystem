using Abp.Application.Services.Dto;
using Abp.AutoMapper;
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
        public string BookAuthor { get; set; }
        public bool IsBorrowed { get; set; }
        public string BookCategoryId { get; set; }
        public BookCategoryDto BookCategories { get; set; }

    }
}
