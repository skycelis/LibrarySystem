using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using LibrarySystem.Books;
using LibrarySystem.Entities;

namespace LibrarySystem.Authors
{
    [AutoMapTo(typeof(Author))]
    [AutoMapFrom(typeof(Author))]

    public class AuthorDto : EntityDto<int>
    {
        public string Name { get; set; }

    }
}
