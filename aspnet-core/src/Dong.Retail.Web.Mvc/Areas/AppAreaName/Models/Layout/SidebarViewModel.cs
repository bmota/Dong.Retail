using Abp.Application.Navigation;

namespace Dong.Retail.Web.Areas.AppAreaName.Models.Layout
{
    public class SidebarViewModel
    {
        public UserMenu Menu { get; set; }

        public string CurrentPageName { get; set; }
    }
}