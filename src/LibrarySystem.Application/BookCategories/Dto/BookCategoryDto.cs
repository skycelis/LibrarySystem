using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities;
using LibrarySystem.Authorization.Users;
using LibrarySystem.Departments.Dto;
using LibrarySystem.Entities;

namespace LibrarySystem.BookCategories
{
    [AutoMapFrom(typeof(BookCategory))]
    [AutoMapTo(typeof(BookCategory))]
    public class BookCategoryDto : EntityDto<int>
    {
        public string Name { get; set; }

        public int DepartmentId { get; set; }

        public List<DepartmentDto> Departments { get; set; }
    }
}
