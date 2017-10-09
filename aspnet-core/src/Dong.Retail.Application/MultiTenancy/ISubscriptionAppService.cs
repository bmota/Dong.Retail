using System.Threading.Tasks;
using Abp.Application.Services;

namespace Dong.Retail.MultiTenancy
{
    public interface ISubscriptionAppService : IApplicationService
    {
        Task UpgradeTenantToEquivalentEdition(int upgradeEditionId);
    }
}
