﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Models
{
    public interface IVolunteerRepository
    {
        IEnumerable<Volunteer> Volunteers { get; }
    }
}
