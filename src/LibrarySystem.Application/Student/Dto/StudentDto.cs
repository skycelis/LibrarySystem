using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities;
using LibrarySystem.Authorization.Users;
using LibrarySystem.Entities;

namespace LibrarySystem.Student.Dto
{
    [AutoMapFrom(typeof(StudentDto))]
    [AutoMapTo(typeof(StudentDto))]
    public class StudentDto : EntityDto<int>
    {
        public string Name { get; set; }

    }
}
