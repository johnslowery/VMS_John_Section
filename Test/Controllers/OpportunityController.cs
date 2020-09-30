using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Test.Models;

namespace Test.Controllers
{
    public class OpportunityController : Controller
    {
        private IOpportunityRepository repository;
        private readonly AppDbContext context;

        public OpportunityController(AppDbContext context, IOpportunityRepository repo)
        {
            this.context = context;
            repository = repo;
        }

        public ViewResult Opportunities() => View(repository.Opportunities);

        public async Task<IActionResult> SearchOpp(string searchString)
        {
            var opportunities = from v in context.Opportunities select v;
            if (!String.IsNullOrEmpty(searchString))
            {
                opportunities = opportunities.Where(s => s.Name.Contains(searchString));
            }
            return View(await opportunities.ToListAsync());
        }
    }
}
