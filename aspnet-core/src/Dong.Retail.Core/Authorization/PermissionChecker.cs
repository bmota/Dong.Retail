using Abp.Authorization;
using Dong.Retail.Authorization.Roles;
using Dong.Retail.Authorization.Users;

namespace Dong.Retail.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
