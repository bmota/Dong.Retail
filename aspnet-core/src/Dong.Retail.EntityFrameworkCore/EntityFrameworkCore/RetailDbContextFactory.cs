using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Dong.Retail.Configuration;
using Dong.Retail.Web;

namespace Dong.Retail.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class RetailDbContextFactory : IDesignTimeDbContextFactory<RetailDbContext>
    {
        public RetailDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<RetailDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            RetailDbContextConfigurer.Configure(builder, configuration.GetConnectionString(RetailConsts.ConnectionStringName));

            return new RetailDbContext(builder.Options);
        }
    }
}