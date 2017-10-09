using System.Threading.Tasks;
using Abp.Application.Services;
using Dong.Retail.Sessions.Dto;

namespace Dong.Retail.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();

        Task<UpdateUserSignInTokenOutput> UpdateUserSignInToken();
    }
}
