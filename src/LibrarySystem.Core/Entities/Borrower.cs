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
        public int? ExpectedReturnDate { get; set; }
        public int? ReturnDate { get; set; }
        public int? BookId { get; set; }
        public int StudentId { get; set; }
        public Book Book { get; set; }
        public Student Student { get; set; }

    }
}
