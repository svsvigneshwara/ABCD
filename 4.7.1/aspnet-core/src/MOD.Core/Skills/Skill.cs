using Abp.Domain.Entities;
using MOD.SkillGroup;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MOD.Skills
{
    public class Skill : Entity<long>,ISkil
    {
        public string Name { get; set; }
        public long SkillsGroupId { get; set; }
        [ForeignKey("SkillsGroupId")]
        public virtual SkillsGroup SkillsGroup { get; set; }
    }
}
