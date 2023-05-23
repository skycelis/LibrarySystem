using LibrarySystem.Departments.Dto;
using System.Collections.Generic;

namespace LibrarySystem.Web.Models.BookCategories
{
    public class CreateOrEditBookCategoryViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DepartmentName { get; set; }
        public List<DepartmentDto> ListDepartments { get; set; }
        public int DepartmentId { get; internal set; }
    }
}
