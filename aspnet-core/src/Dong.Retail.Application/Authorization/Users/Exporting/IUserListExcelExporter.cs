using System.Collections.Generic;
using Dong.Retail.Authorization.Users.Dto;
using Dong.Retail.Dto;

namespace Dong.Retail.Authorization.Users.Exporting
{
    public interface IUserListExcelExporter
    {
        FileDto ExportToFile(List<UserListDto> userListDtos);
    }
}