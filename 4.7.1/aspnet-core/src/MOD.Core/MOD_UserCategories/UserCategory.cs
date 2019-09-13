using Abp.Domain.Entities;
using MOD.MOD_Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace MOD.MOD_UserCategories
{
    public class UserCategory : Entity<long>,IUserCategory
    {
        public string Name { get; set; }
    }
}
