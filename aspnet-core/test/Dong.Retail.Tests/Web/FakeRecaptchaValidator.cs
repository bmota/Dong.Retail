using System.Threading.Tasks;
using Dong.Retail.Security.Recaptcha;

namespace Dong.Retail.Tests.Web
{
    public class FakeRecaptchaValidator : IRecaptchaValidator
    {
        public Task ValidateAsync(string captchaResponse)
        {
            return Task.CompletedTask;
        }
    }
}
