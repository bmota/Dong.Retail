using Abp.Application.Services;
using Dong.Retail.Dto;
using Dong.Retail.Logging.Dto;

namespace Dong.Retail.Logging
{
    public interface IWebLogAppService : IApplicationService
    {
        GetLatestWebLogsOutput GetLatestWebLogs();

        FileDto DownloadWebLogs();
    }
}
