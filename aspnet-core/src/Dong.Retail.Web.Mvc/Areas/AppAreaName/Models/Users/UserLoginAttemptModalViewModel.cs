using System.Collections.Generic;
using Dong.Retail.Authorization.Users.Dto;

namespace Dong.Retail.Web.Areas.AppAreaName.Models.Users
{
    public class UserLoginAttemptModalViewModel
    {
        public List<UserLoginAttemptDto> LoginAttempts { get; set; }
    }
}