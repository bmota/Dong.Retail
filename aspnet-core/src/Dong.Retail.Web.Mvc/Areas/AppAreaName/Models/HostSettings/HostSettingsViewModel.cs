using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Dong.Retail.Configuration.Host.Dto;
using Dong.Retail.Editions.Dto;

namespace Dong.Retail.Web.Areas.AppAreaName.Models.HostSettings
{
    public class HostSettingsViewModel
    {
        public HostSettingsEditDto Settings { get; set; }

        public List<SubscribableEditionComboboxItemDto> EditionItems { get; set; }

        public List<ComboboxItemDto> TimezoneItems { get; set; }
    }
}