using Abp.Application.Services.Dto;
using Abp.AutoMapper;


namespace MOD.MOD_Domains.Dto
{
    [AutoMap(typeof(Domain))]
    public class CreateDomainDto : EntityDto<long>
    {
        public string Name { get; set; }
    }
}
