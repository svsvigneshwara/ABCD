using Abp.Application.Services.Dto;
using Abp.AutoMapper;


namespace MOD.MOD_Features.Dto
{
    [AutoMap(typeof(Features))]
    public class PagedFeaturesResultRequestDto : EntityDto<long>
    {

    }
}
