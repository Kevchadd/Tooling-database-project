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


        public async Task OnGetAsync()
        {
            Tool = await _context.Tools.Skip((PageNum-1)*PageSize).Take(PageSize).ToListAsync();
            TotalToolsCount = await _context.Tools.CountAsync(); // Get total count
        }
    }
}
