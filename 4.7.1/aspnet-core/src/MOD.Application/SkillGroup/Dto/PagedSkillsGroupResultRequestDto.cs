using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace MOD.SkillGroup.Dto
{
    [AutoMap(typeof(SkillsGroup))]
    public class PagedSkillsGroupResultRequestDto : EntityDto<long>
    {
    }
}
