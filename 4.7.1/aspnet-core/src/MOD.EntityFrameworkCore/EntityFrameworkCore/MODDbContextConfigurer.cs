using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace MOD.EntityFrameworkCore
{
    public static class MODDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<MODDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<MODDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
