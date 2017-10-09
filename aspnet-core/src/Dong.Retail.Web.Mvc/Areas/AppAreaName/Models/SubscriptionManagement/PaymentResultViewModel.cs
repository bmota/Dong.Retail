using Abp.AutoMapper;
using Dong.Retail.Editions;
using Dong.Retail.MultiTenancy.Payments.Dto;

namespace Dong.Retail.Web.Areas.AppAreaName.Models.SubscriptionManagement
{
    [AutoMapTo(typeof(ExecutePaymentDto))]
    public class PaymentResultViewModel : SubscriptionPaymentDto
    {
        public EditionPaymentType EditionPaymentType { get; set; }
    }
}