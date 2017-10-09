using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using Dong.Retail.Web.Controllers;

namespace Dong.Retail.Web.Areas.AppAreaName.Controllers
{
    [Area("AppAreaName")]
    [AbpMvcAuthorize]
    public class WelcomeController : RetailControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}