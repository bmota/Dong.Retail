using Abp.AutoMapper;
using Dong.Retail.MultiTenancy.Payments;

namespace Dong.Retail.Sessions.Dto
{
    [AutoMapFrom(typeof(SubscriptionPayment))]
    public class SubscriptionPaymentInfoDto
    {
        public decimal Amount { get; set; }
    }
}