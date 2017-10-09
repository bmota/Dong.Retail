using Abp.Auditing;
using Microsoft.AspNetCore.Mvc;

namespace Dong.Retail.Web.Controllers
{
    public class HomeController : RetailControllerBase
    {
        [DisableAuditing]
        public IActionResult Index()
        {
            return Redirect("/swagger");
        }
    }
}
