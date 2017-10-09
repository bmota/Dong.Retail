using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace Dong.Retail.Web.Public.Views
{
    public abstract class RetailRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected RetailRazorPage()
        {
            LocalizationSourceName = RetailConsts.LocalizationSourceName;
        }
    }
}
