using Abp.AutoMapper;
using Abp.Organizations;

namespace Dong.Retail.Web.Areas.AppAreaName.Models.OrganizationUnits
{
    [AutoMapFrom(typeof(OrganizationUnit))]
    public class EditOrganizationUnitModalViewModel
    {
        public long? Id { get; set; }

        public string DisplayName { get; set; }
    }
}