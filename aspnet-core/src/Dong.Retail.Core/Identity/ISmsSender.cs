using System.Threading.Tasks;

namespace Dong.Retail.Identity
{
    public interface ISmsSender
    {
        Task SendAsync(string number, string message);
    }
}