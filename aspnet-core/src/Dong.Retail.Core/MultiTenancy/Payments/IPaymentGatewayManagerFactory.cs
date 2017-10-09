using Abp.Dependency;

namespace Dong.Retail.MultiTenancy.Payments
{
    public interface IPaymentGatewayManagerFactory
    {
        IDisposableDependencyObjectWrapper<IPaymentGatewayManager> Create(SubscriptionPaymentGatewayType gateway);
    }
}