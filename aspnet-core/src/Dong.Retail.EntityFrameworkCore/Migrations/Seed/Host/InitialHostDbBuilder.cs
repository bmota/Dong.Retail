using Dong.Retail.EntityFrameworkCore;

namespace Dong.Retail.Migrations.Seed.Host
{
    public class InitialHostDbBuilder
    {
        private readonly RetailDbContext _context;

        public InitialHostDbBuilder(RetailDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            new DefaultEditionCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();

            _context.SaveChanges();
        }
    }
}
