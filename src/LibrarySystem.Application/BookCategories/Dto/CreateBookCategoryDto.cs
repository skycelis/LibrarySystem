using System.Collections.Generic;
using Abp.AutoMapper;
using LibrarySystem.Entities;
using LibrarySystem.Departments.Dto;
using System.ComponentModel.DataAnnotations;

namespace LibrarySystem.BookCategories.Dto
{
    [AutoMapTo(typeof(BookCategory))]
    public class CreateBookCategoryDto
    {
        [Required]
        public string Name { get; set; }
        public int DepartmentId { get; set; }
    }
}
