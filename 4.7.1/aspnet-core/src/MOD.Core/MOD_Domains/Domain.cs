using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MOD.MOD_Domains
{
    public class Domain : Entity<long>,IDomain
    {
        public string Name { get; set; }
    }
}
