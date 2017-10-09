using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Dong.Retail.MultiTenancy.HostDashboard.Dto;

namespace Dong.Retail.MultiTenancy.HostDashboard
{
    public interface IIncomeStatisticsService
    {
        Task<List<IncomeStastistic>> GetIncomeStatisticsData(DateTime startDate, DateTime endDate,
            ChartDateInterval dateInterval);
    }
}