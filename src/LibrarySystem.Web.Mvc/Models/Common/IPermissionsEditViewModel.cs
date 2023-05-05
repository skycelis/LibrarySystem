using System.Collections.Generic;
using LibrarySystem.Roles.Dto;

namespace LibrarySystem.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}