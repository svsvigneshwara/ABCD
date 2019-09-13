using Abp.Application.Services.Dto;
using Abp.AutoMapper;


namespace MOD.SkillGroup.Dto
{
    [AutoMap(typeof(SkillsGroup))]
    public class SkillsGroupDto : EntityDto<long>
    {
        public string Name { get; set; }
        public long DomainId { get; set; }
    }
}