using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Final_Tooling_Project.Models;

namespace Final_Project.Pages.Tools
{
    public class AddLocationModel : PageModel
    {
        private readonly ToolDbContext _context;

        public AddLocationModel(ToolDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Location Location { get; set; }

        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Locations.Add(Location);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
