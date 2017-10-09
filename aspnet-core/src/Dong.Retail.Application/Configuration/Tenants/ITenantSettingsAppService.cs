using System.Threading.Tasks;
using Abp.Application.Services;
using Dong.Retail.Configuration.Tenants.Dto;

namespace Dong.Retail.Configuration.Tenants
{
    public interface ITenantSettingsAppService : IApplicationService
    {
        Task<TenantSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(TenantSettingsEditDto input);

        Task ClearLogo();

        Task ClearCustomCss();
    }
}
