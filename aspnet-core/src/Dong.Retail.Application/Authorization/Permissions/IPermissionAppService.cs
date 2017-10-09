using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Dong.Retail.Authorization.Permissions.Dto;

namespace Dong.Retail.Authorization.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions();
    }
}
