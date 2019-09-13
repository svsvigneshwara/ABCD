using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using MOD.Configuration;
using MOD.Web;

namespace MOD.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class MODDbContextFactory : IDesignTimeDbContextFactory<MODDbContext>
    {
        public MODDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<MODDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            MODDbContextConfigurer.Configure(builder, configuration.GetConnectionString(MODConsts.ConnectionStringName));

            return new MODDbContext(builder.Options);
        }
    }
}
