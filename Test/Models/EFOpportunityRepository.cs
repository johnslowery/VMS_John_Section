using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Models
{
    public class EFOpportunityRepository : IOpportunityRepository
    {
        private AppDbContext context;
        public EFOpportunityRepository(AppDbContext ctx)
        {
            context = ctx;
        }
        public IEnumerable<Opportunity> Opportunities => context.Opportunities;
    }
}
