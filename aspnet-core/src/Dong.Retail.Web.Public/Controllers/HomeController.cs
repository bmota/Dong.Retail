using Microsoft.AspNetCore.Mvc;
using Dong.Retail.Web.Controllers;

namespace Dong.Retail.Web.Public.Controllers
{
    public class HomeController : RetailControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}