using Abp.Application.Services.Dto;
using Abp.AutoMapper;


namespace MOD.MOD_Domains.Dto
{
    [AutoMap(typeof(Domain))]
    public class PagedDomainResultRequestDto : EntityDto<long>
    {

    }
}
