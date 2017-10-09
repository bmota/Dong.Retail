using Dong.Retail.Dto;

namespace Dong.Retail.Common.Dto
{
    public class FindUsersInput : PagedAndFilteredInputDto
    {
        public int? TenantId { get; set; }
    }
}