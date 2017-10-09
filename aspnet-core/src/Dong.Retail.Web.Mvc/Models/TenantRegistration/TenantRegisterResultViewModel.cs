using Abp.AutoMapper;
using Dong.Retail.MultiTenancy.Dto;

namespace Dong.Retail.Web.Models.TenantRegistration
{
    [AutoMapFrom(typeof(RegisterTenantOutput))]
    public class TenantRegisterResultViewModel : RegisterTenantOutput
    {
        public string TenantLoginAddress { get; set; }
    }
}