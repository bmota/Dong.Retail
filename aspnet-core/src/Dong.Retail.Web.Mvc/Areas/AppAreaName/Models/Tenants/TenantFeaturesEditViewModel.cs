using Abp.AutoMapper;
using Dong.Retail.MultiTenancy;
using Dong.Retail.MultiTenancy.Dto;
using Dong.Retail.Web.Areas.AppAreaName.Models.Common;

namespace Dong.Retail.Web.Areas.AppAreaName.Models.Tenants
{
    [AutoMapFrom(typeof (GetTenantFeaturesEditOutput))]
    public class TenantFeaturesEditViewModel : GetTenantFeaturesEditOutput, IFeatureEditViewModel
    {
        public Tenant Tenant { get; set; }

        public TenantFeaturesEditViewModel(Tenant tenant, GetTenantFeaturesEditOutput output)
        {
            Tenant = tenant;
            output.MapTo(this);
        }
    }
}