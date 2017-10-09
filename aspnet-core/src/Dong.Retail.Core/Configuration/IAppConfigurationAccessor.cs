using Microsoft.Extensions.Configuration;

namespace Dong.Retail.Configuration
{
    public interface IAppConfigurationAccessor
    {
        IConfigurationRoot Configuration { get; }
    }
}
