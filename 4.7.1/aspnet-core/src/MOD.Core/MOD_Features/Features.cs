using Abp.Domain.Entities;
using MOD.MOD_Roles;
using System;
using System.Collections.Generic;
using System.Text;

namespace MOD.MOD_Features
{
    public class Features : Entity<long>,IFeatures
    {
        public string Name { get; set; }
        
    }
}
