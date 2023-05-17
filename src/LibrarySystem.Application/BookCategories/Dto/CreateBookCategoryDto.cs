using System.Collections.Generic;
using Abp.AutoMapper;
using LibrarySystem.Entities;
using LibrarySystem.Departments.Dto;

namespace LibrarySystem.BookCategories.Dto
{
    [AutoMapTo(typeof(BookCategory))]
    public class CreateBookCategoryDto
    {
        public string Name { get; set; }
        public int DepartmentId { get; set; }
        public List<DepartmentDto> Departments { get; set; }
    }
}
