using Dong.Retail.EntityFrameworkCore;

namespace Dong.Retail.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly RetailDbContext _context;
        private readonly int _tenantId;

        public TestDataBuilder(RetailDbContext context, int tenantId)
        {
            _context = context;
            _tenantId = tenantId;
        }

        public void Create()
        {
            new TestOrganizationUnitsBuilder(_context, _tenantId).Create();
            new TestSubscriptionPaymentBuilder(_context, _tenantId).Create();

            _context.SaveChanges();
        }
    }
}
