using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities.Auditing;


namespace LibrarySystem.Entities
{
    public class Book : FullAuditedEntity<int>
    {
        public string Name { get; set; }

        public int? DepartmentId { get; set; }

        public Department Department { get; set; }
    }
}
