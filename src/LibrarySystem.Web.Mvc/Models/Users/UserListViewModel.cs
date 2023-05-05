using System.Collections.Generic;
using LibrarySystem.Roles.Dto;

namespace LibrarySystem.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
