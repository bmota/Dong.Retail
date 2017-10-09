using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Dong.Retail.EntityFrameworkCore
{
    public static class RetailDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<RetailDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<RetailDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}