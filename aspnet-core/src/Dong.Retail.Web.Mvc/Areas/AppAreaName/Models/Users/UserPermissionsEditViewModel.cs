using Abp.AutoMapper;
using Dong.Retail.Authorization.Users;
using Dong.Retail.Authorization.Users.Dto;
using Dong.Retail.Web.Areas.AppAreaName.Models.Common;

namespace Dong.Retail.Web.Areas.AppAreaName.Models.Users
{
    [AutoMapFrom(typeof(GetUserPermissionsForEditOutput))]
    public class UserPermissionsEditViewModel : GetUserPermissionsForEditOutput, IPermissionsEditViewModel
    {
        public User User { get; private set; }

        public UserPermissionsEditViewModel(GetUserPermissionsForEditOutput output, User user)
        {
            User = user;
            output.MapTo(this);
        }
    }
}