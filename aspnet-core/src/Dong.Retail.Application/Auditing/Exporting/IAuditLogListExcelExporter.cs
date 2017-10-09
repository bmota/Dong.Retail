using System.Collections.Generic;
using Dong.Retail.Auditing.Dto;
using Dong.Retail.Dto;

namespace Dong.Retail.Auditing.Exporting
{
    public interface IAuditLogListExcelExporter
    {
        FileDto ExportToFile(List<AuditLogListDto> auditLogListDtos);
    }
}
