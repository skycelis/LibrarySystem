using LibrarySystem.Authors;
using LibrarySystem.Authors.Dto;
using System.Collections.Generic;

namespace LibrarySystem.Web.Models.Authors
{
    public class AuthorViewModel
    {
        public List<AuthorDto> Authors { get; set; }
    }
}
