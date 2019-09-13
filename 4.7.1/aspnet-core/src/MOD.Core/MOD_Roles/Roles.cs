using Abp.Domain.Entities;
using MOD.MOD_Features;
using MOD.MOD_Users;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MOD.MOD_Roles
{
    public class Roles : Entity<long>,IRoles
    {
        public string Name { get; set; }
        
        public string Permissions { get; set; }
        public long FeaturesId { get; set; }
        [ForeignKey("FeaturesId")]
        public virtual Features Features { get; set; }
        

    }
}
