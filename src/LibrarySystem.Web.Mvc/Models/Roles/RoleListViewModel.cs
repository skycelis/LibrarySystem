using System.Collections.Generic;
using LibrarySystem.Roles.Dto;

namespace LibrarySystem.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
