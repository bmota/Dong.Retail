using Abp.Domain.Services;

namespace Dong.Retail
{
    public abstract class RetailDomainServiceBase : DomainService
    {
        /* Add your common members for all your domain services. */

        protected RetailDomainServiceBase()
        {
            LocalizationSourceName = RetailConsts.LocalizationSourceName;
        }
    }
}
