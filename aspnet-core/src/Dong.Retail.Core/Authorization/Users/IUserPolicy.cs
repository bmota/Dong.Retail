using System.Threading.Tasks;
using Abp.Domain.Policies;

namespace Dong.Retail.Authorization.Users
{
    public interface IUserPolicy : IPolicy
    {
        Task CheckMaxUserCountAsync(int tenantId);
    }
}
