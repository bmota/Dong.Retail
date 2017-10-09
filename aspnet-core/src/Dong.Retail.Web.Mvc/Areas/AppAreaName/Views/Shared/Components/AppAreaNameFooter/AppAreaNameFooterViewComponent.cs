using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dong.Retail.Web.Areas.AppAreaName.Models.Layout;
using Dong.Retail.Web.Session;
using Dong.Retail.Web.Views;

namespace Dong.Retail.Web.Areas.AppAreaName.Views.Shared.Components.AppAreaNameFooter
{
    public class AppAreaNameFooterViewComponent : RetailViewComponent
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public AppAreaNameFooterViewComponent(IPerRequestSessionCache sessionCache)
        {
            _sessionCache = sessionCache;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var footerModel = new FooterViewModel
            {
                LoginInformations = await _sessionCache.GetCurrentLoginInformationsAsync()
            };

            return View(footerModel);
        }
    }
}
