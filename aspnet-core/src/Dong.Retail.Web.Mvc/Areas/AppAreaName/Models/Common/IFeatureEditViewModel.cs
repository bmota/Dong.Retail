using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Dong.Retail.Editions.Dto;

namespace Dong.Retail.Web.Areas.AppAreaName.Models.Common
{
    public interface IFeatureEditViewModel
    {
        List<NameValueDto> FeatureValues { get; set; }

        List<FlatFeatureDto> Features { get; set; }
    }
}