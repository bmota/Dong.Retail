using System.Collections.Generic;
using Dong.Retail.Authorization.Permissions.Dto;

namespace Dong.Retail.Web.Areas.AppAreaName.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }

        List<string> GrantedPermissionNames { get; set; }
    }
}