<<<<<<< HEAD
﻿using LibrarySystem.Books;
=======
﻿using LibrarySystem.Authors;
using LibrarySystem.Books;
>>>>>>> 80d52e39396ba3c78fb4a4a9ac8f79193bf2a815
using LibrarySystem.Departments.Dto;
using System.Collections.Generic;

namespace LibrarySystem.Web.Models.Authors
{
    public class CreateOrEditAuthorViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
<<<<<<< HEAD
        public int BookId { get; set; }
        public List<BookDto> ListBooks { get; set; }
       
=======
        public List<BookDto> Books { get; set; }
>>>>>>> 80d52e39396ba3c78fb4a4a9ac8f79193bf2a815
    }
}
