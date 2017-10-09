using Microsoft.AspNetCore.Mvc;
using Dong.Retail.Web.Controllers;

namespace Dong.Retail.Web.Public.Controllers
{
    public class AboutController : RetailControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}