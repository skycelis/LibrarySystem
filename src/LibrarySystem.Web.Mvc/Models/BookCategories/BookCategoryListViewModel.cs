using LibrarySystem.BookCategories;
using LibrarySystem.Departments.Dto;
using System.Collections.Generic;

namespace LibrarySystem.Web.Models.BookCategories
{
    public class BookCategoryListViewModel
    {
        public List<BookCategoryDto> BookCategories { get; set; }
    }
}
