using Abp.Domain.Entities;
using MOD.MOD_Domains;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MOD.SkillGroup
{
    public class SkillsGroup : Entity<long>,ISkillsGroup
    {
        public string Name { get; set; }
        public long DomainId { get; set; }
        [ForeignKey("DomainId")]
        public virtual Domain Domain { get; set; }
    }
}
