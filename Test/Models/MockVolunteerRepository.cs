using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Models
{
    public class MockVolunteerRepository : IVolunteerRepository
    {
        public IEnumerable<Volunteer> Volunteers => new List<Volunteer>
        {
            new Volunteer(){Id = 1, FirstName = "John", LastName = "1234"},
            new Volunteer(){Id = 1, FirstName = "Jack", LastName = "1234"},
            new Volunteer(){Id = 1, FirstName = "Joe", LastName = "1234"}
        };
    }
}
