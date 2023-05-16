using LibrarySystem.Departments.Dto;
using System.Collections.Generic;

namespace LibrarySystem.Web.Models.BookCategories
{
    public class CreateOrEditBookCategoryListViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<DepartmentDto> ListDepartments { get; set; }
    }
}
