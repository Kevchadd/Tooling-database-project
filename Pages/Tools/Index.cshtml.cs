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
    public class IndexModel : PageModel
    {
        private readonly Final_Tooling_Project.Models.ToolDbContext _context;

        public IndexModel(Final_Tooling_Project.Models.ToolDbContext context)
        {
            _context = context;
        }

        public IList<Tool> Tool { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Tool = await _context.Tools.ToListAsync();
        }
    }
}
