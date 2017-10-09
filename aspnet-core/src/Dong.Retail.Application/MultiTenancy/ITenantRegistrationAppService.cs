using System.Threading.Tasks;
using Abp.Application.Services;
using Dong.Retail.Editions.Dto;
using Dong.Retail.MultiTenancy.Dto;

namespace Dong.Retail.MultiTenancy
{
    public interface ITenantRegistrationAppService: IApplicationService
    {
        Task<RegisterTenantOutput> RegisterTenant(RegisterTenantInput input);

        Task<EditionsSelectOutput> GetEditionsForSelect();

        Task<EditionSelectDto> GetEdition(int editionId);
    }
}