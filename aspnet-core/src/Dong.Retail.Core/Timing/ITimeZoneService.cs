using System.Threading.Tasks;
using Abp.Configuration;

namespace Dong.Retail.Timing
{
    public interface ITimeZoneService
    {
        Task<string> GetDefaultTimezoneAsync(SettingScopes scope, int? tenantId);
    }
}
