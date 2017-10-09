using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Dong.Retail.Configuration.Tenants.Dto;

namespace Dong.Retail.Web.Areas.AppAreaName.Models.Settings
{
    public class SettingsViewModel
    {
        public TenantSettingsEditDto Settings { get; set; }
        
        public List<ComboboxItemDto> TimezoneItems { get; set; }
    }
}