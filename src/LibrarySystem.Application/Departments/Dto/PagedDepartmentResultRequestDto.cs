using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;

namespace LibrarySystem.Departments.Dto
{
    public class PagedDepartmentResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }

        public bool? IsActive { get; set; }

    }
}
