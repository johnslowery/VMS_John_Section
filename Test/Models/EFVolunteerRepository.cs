using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Models
{
    public class EFVolunteerRepository : IVolunteerRepository
    {
        private AppDbContext context;
        public EFVolunteerRepository(AppDbContext ctx)
        {
            context = ctx;
        }
        public IEnumerable<Volunteer> Volunteers => context.Volunteers;
    }
}
