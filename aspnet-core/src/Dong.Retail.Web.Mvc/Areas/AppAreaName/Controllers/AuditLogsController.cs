using Abp.AspNetCore.Mvc.Authorization;
using Abp.Auditing;
using Microsoft.AspNetCore.Mvc;
using Dong.Retail.Authorization;
using Dong.Retail.Web.Controllers;

namespace Dong.Retail.Web.Areas.AppAreaName.Controllers
{
    [Area("AppAreaName")]
    [DisableAuditing]
    [AbpMvcAuthorize(AppPermissions.Pages_Administration_AuditLogs)]
    public class AuditLogsController : RetailControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}