using System.Threading.Tasks;

namespace Dong.Retail.Security.Recaptcha
{
    public interface IRecaptchaValidator
    {
        Task ValidateAsync(string captchaResponse);
    }
}