using Abp.Notifications;
using Dong.Retail.Dto;

namespace Dong.Retail.Notifications.Dto
{
    public class GetUserNotificationsInput : PagedInputDto
    {
        public UserNotificationState? State { get; set; }
    }
}