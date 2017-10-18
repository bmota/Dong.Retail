using System.Linq;
using Abp.MultiTenancy;
using Abp.Organizations;
using Microsoft.EntityFrameworkCore;
using Dong.Retail.Editions;
using Dong.Retail.EntityFrameworkCore;

namespace Dong.Retail.Migrations.Seed.Tenants
{
    public class DefaultTenantBuilder
    {
        private readonly RetailDbContext _context;

        public DefaultTenantBuilder(RetailDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateDefaultTenant();
        }

        private void CreateDefaultTenant()
        {

            //默认组织
            
            var defaultOrg = _context.OrganizationUnits.IgnoreQueryFilters().FirstOrDefault(t => t.DisplayName == AbpTenantBase.DefaultTenantName);
            if (defaultOrg == null)
            {

                defaultOrg =
                    new OrganizationUnit(null, AbpTenantBase.DefaultTenantName)
                    { Code = OrganizationUnit.CreateCode(1)};
                _context.OrganizationUnits.Add(defaultOrg);
                _context.SaveChanges();
            }


            //默认租户
            var defaultTenant = _context.Tenants.IgnoreQueryFilters().FirstOrDefault(t => t.TenancyName == AbpTenantBase.DefaultTenantName);
            if (defaultTenant == null)
            {
                defaultTenant = new MultiTenancy.Tenant(AbpTenantBase.DefaultTenantName,
                    AbpTenantBase.DefaultTenantName, defaultOrg.Id);

                var defaultEdition = _context.Editions.IgnoreQueryFilters().FirstOrDefault(e => e.Name == EditionManager.DefaultEditionName);
                if (defaultEdition != null)
                {
                    defaultTenant.EditionId = defaultEdition.Id;
                }


                _context.Tenants.Add(defaultTenant);
                _context.SaveChanges();
            }
        }
    }
}
