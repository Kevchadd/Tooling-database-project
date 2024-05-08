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
        [BindProperty(SupportsGet = true)]
        public int PageNum {get;set;} = 1;

        public int PageSize { get;set; } = 8;

        public int TotalToolsCount { get; set; } 

        [BindProperty(SupportsGet = true)]
        public string? CurrentSort {get;set; }

        public async Task OnGetAsync()
        {
            TotalToolsCount = await _context.Tools.CountAsync(); // Get total count

            var query = _context.Tools.Select(t =>t);

            switch (CurrentSort)
            {
                case "first_asc":
                    query = query.OrderBy(t => t.ToolName);
                    break;
 
                    case "first_desc":
                    query = query.OrderByDescending(t => t.ToolName);
                    break;


            }

            Tool = await query.Skip((PageNum-1)*PageSize).Take(PageSize).ToListAsync();
           
        }
    }
}
