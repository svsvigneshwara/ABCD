using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MOD.Authorization.Roles;
using MOD.MOD_Roles;
using MOD.MOD_Users;
using MOD.Authorization.Users;
using MOD.MultiTenancy;
using MOD.MOD_Features;
using MOD.MOD_UserCategories;
using MOD.MOD_Domains;
using MOD.SkillGroup;
using MOD.Skills;

namespace MOD.EntityFrameworkCore
{
    public class MODDbContext : AbpZeroDbContext<Tenant, Role, User, MODDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Features> MOD_Feature { get; set; }
        public DbSet<Roles> MOD_Role { get; set; }
        public DbSet<Users> MOD_User { get; set; } 
        public DbSet<UserCategory> UserCategory { get; set; }
        public DbSet<Domain> Domain { get; set; }
        public DbSet<SkillsGroup> skillsGroup { get; set; }
        public DbSet<Skill> Skill { get; set; }
        public MODDbContext(DbContextOptions<MODDbContext> options)
            : base(options)
        {
        }
    }
}
