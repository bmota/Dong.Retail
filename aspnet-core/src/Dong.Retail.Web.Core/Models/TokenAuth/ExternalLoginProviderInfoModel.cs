using Abp.AutoMapper;
using Dong.Retail.Web.Authentication.External;

namespace Dong.Retail.Web.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
