using System.Threading.Tasks;
using Abp.Application.Services;
using Dong.Retail.MultiTenancy.Dto;
using Dong.Retail.MultiTenancy.Payments.Dto;
using Abp.Application.Services.Dto;

namespace Dong.Retail.MultiTenancy.Payments
{
    public interface IPaymentAppService : IApplicationService
    {
        Task<PaymentInfoDto> GetPaymentInfo(PaymentInfoInput input);

        Task<CreatePaymentResponse> CreatePayment(CreatePaymentDto input);

        Task<ExecutePaymentResponse> ExecutePayment(ExecutePaymentDto input);

        Task<PagedResultDto<SubscriptionPaymentListDto>> GetPaymentHistory(GetPaymentHistoryInput input);
    }
}
