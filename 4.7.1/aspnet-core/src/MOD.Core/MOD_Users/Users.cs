using Abp.Domain.Entities;
using MOD.MOD_Roles;
using MOD.MOD_UserCategories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MOD.MOD_Users
{
    public class Users : Entity<long>,IUsers
    {
        public string Name { get; set; }
        public long RolesId { get; set; }
        public long UserCategoryId { get; set; }
        [ForeignKey("RolesId")]
        public virtual Roles Roles { get; set; }    
        [ForeignKey("UserCategoryId")]
        public virtual UserCategory UserCategory { get; set; }
    }
}
