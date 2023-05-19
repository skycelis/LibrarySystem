using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Entities
{
    public class Borrower : FullAuditedEntity<int>
    {
        public object BorrowerDate { get; set; }
        public string ExpectedReturnDate { get; set; }
        public string ReturnDate { get; set; }
        public string BookId { get; set; }
        public string StudentId { get; set; }
        public Book Book { get; set; }
        public Student Student { get; set; }

    }
}
