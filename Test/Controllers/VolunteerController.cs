using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Test.Models;

namespace Test.Controllers
{
    public class VolunteerController : Controller
    {
        private IVolunteerRepository repository;
        private readonly AppDbContext context;

        public VolunteerController(AppDbContext context, IVolunteerRepository repo)
        {
            this.context = context;
            repository = repo;
        }

        public ViewResult Volunteers() => View(repository.Volunteers);

        public async Task<IActionResult> SearchVol(string searchString)
        {
            var volunteers = from v in context.Volunteers select v;
            if (!String.IsNullOrEmpty(searchString))
            {
                volunteers = volunteers.Where(s => s.FirstName.Contains(searchString));
            }
            return View(await volunteers.ToListAsync());
        }
    }
}
