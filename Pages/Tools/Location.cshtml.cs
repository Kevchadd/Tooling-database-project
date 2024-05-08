using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Final_Tooling_Project.Models;

namespace Final_Project.Pages.Tools
{
    public class LocationModel : PageModel
    {
        private readonly Final_Tooling_Project.Models.ToolDbContext _context;

        public LocationModel(Final_Tooling_Project.Models.ToolDbContext context)
        {
            _context = context;
        }

        public IList<Location> Locations { get; set; } = new List<Location>(); 

        [BindProperty(SupportsGet = true)]
        public int PageNum { get; set; } = 1;

        public int PageSize { get; set; } = 2;

        public int TotalLocCount { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? CurrentSort { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
           Locations = await _context.Locations.Include(l => l.Tools).ToListAsync();

            TotalLocCount = await _context.Locations.CountAsync(); // Get total count

            var query = _context.Locations.Select(t => t);

            switch (CurrentSort)
            {
                case "first_asc":
                    query = query.OrderBy(t => t.LocationDesc);
                    break;

                case "first_desc":
                    query = query.OrderByDescending(t => t.LocationDesc);
                    break;
            }


            Locations = await query.Skip((PageNum - 1) * PageSize).Take(PageSize).ToListAsync(); 

            return Page(); 
        }
    }
}
