using System.Threading.Tasks;
using Dong.Retail.Sessions.Dto;

namespace Dong.Retail.Web.Session
{
    public interface IPerRequestSessionCache
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformationsAsync();
    }
}
