using System.Collections.Generic;
using Dong.Retail.Caching.Dto;

namespace Dong.Retail.Web.Areas.AppAreaName.Models.Maintenance
{
    public class MaintenanceViewModel
    {
        public IReadOnlyList<CacheDto> Caches { get; set; }
    }
}