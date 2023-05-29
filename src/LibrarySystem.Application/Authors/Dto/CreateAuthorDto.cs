using System.Collections.Generic;
using Abp.AutoMapper;
using LibrarySystem.Books;
using LibrarySystem.Entities;

namespace LibrarySystem.Authors.Dto
{
    [AutoMapTo(typeof(Author))]
    public class CreateAuthorDto
    {
        public string Name { get; set; }
        public int BookId { get; set; }
    }
}
