using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Final_Tooling_Project.Models;

namespace Final_Project.Pages.Tools
{
    public class SearchModel : PageModel
    {
        private readonly Final_Tooling_Project.Models.ToolDbContext _context;

        public SearchModel(Final_Tooling_Project.Models.ToolDbContext context)
        {
            _context = context;
        }

        public IList<Tool> Tools { get; set; }

        public async Task<IActionResult> OnGetAsync(string searchTerm)
        {
            if (string.IsNullOrEmpty(searchTerm))
            {
                return Page();
            }
            //Bring in location make lowercase
            Tools = await _context.Tools
                .Include(t => t.Location)
                .Where(t => EF.Functions.Like(t.ToolName.ToLower(), $"%{searchTerm.ToLower()}%") ||
                            EF.Functions.Like(t.Location.LocationDesc.ToLower(), $"%{searchTerm.ToLower()}%"))
                .ToListAsync();

            return Page();
        }
    }
}
