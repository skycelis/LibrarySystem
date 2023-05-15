using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Domain.Entities;
using Abp.AutoMapper;
using LibrarySystem.Entities;
using LibrarySystem.Departments.Dto;

namespace LibrarySystem.BookCategories.Dto
{
    [AutoMapTo(typeof(BookCategoryDto))]
    public class CreateBookCategoryDto
    {
        public string Name { get; set; }

        public int DepartmentId { get; set; }

        public List<DepartmentDto> Departments { get; set; }
    }
}
