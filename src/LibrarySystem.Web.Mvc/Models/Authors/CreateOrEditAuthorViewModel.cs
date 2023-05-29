﻿using LibrarySystem.Books;
using LibrarySystem.Departments.Dto;
using System.Collections.Generic;

namespace LibrarySystem.Web.Models.Authors
{
    public class CreateOrEditAuthorViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BookId { get; set; }
        public List<BookDto> ListBooks { get; set; }
       
    }
}
