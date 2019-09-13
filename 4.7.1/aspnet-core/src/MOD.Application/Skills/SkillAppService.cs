using Abp.Application.Services;
using Abp.Domain.Repositories;
using MOD.Skills.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MOD.Skills
{
    public class SkillAppService : AsyncCrudAppService<Skill, SkillDto, long, PagedSkillResultRequestDto, CreateSkillDto, UpdateSkillDto>
    {
        public SkillAppService(IRepository<Skill, long> repository) : base(repository)
        {

        }
    }
}
