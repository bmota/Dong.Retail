using System.Collections.Generic;
using Dong.Retail.Authorization.Permissions.Dto;

namespace Dong.Retail.Authorization.Users.Dto
{
    public class GetUserPermissionsForEditOutput
    {
        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}