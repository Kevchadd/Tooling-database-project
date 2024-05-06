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
    public class DetailsModel : PageModel
    {
        private readonly Final_Tooling_Project.Models.ToolDbContext _context;

        public DetailsModel(Final_Tooling_Project.Models.ToolDbContext context)
        {
            _context = context;
        }

        public Tool Tool { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tool = await _context.Tools.Include(m => m.Locations).FirstOrDefaultAsync(m => m.ToolId == id);
            if (tool == null)
            {
                return NotFound();
            }
            else
            {
                Tool = tool;
            }
            return Page();
        }
    }
}
