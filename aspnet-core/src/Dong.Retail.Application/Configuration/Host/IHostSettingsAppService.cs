using System.Threading.Tasks;
using Abp.Application.Services;
using Dong.Retail.Configuration.Host.Dto;

namespace Dong.Retail.Configuration.Host
{
    public interface IHostSettingsAppService : IApplicationService
    {
        Task<HostSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(HostSettingsEditDto input);

        Task SendTestEmail(SendTestEmailInput input);
    }
}
