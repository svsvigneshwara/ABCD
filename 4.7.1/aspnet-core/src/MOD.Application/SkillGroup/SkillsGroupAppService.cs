using Abp.Application.Services;
using Abp.Domain.Repositories;
using MOD.SkillGroup.Dto;


namespace MOD.SkillGroup
{
    public class SkillsGroupAppService : AsyncCrudAppService<SkillsGroup, SkillsGroupDto, long, PagedSkillsGroupResultRequestDto, CreateSkillsGroupDto, UpdateSkillsGroupDto>
    {
        public SkillsGroupAppService(IRepository<SkillsGroup, long> repository) : base(repository)
        {

        }
    }
}
