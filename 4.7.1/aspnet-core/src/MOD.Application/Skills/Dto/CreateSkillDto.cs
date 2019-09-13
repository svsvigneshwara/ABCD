using Abp.Application.Services.Dto;
using Abp.AutoMapper;


namespace MOD.Skills.Dto
{
    [AutoMap(typeof(Skill))]
    public class CreateSkillDto : EntityDto<long>
    {
        public string Name { get; set; }
        public long SkillsGroupId { get; set; }
    }
}
