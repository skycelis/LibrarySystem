﻿using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Entities
{
    public class Book : FullAuditedEntity<int>
    {
        public string BookTitle { get; set; }
        public string BookPublisher { get; set; }
        public bool IsBorrowed { get; set; }
        public int? BookCategoryId { get; set; }
        public BookCategory BookCategory { get; set; }
        public int? AuthorId { get; set; }
        public Author Author { get; set; }

    }
}
