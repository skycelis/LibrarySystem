using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarySystem.Entities;
using Abp.AutoMapper;

namespace LibrarySystem.Students.Dto
{
    [AutoMapTo(typeof(Student))]
    public class CreateStudentDto 
    {
        public string Name { get; set; }
    }
}
