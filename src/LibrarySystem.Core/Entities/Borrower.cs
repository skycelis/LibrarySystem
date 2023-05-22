﻿using System;
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
        public DateTime BorrowerDate { get; set; }
        public DateTime ExpectedReturnDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public Book Book { get; set; }
        public Student Student { get; set; }

    }
}
