using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Final_Tooling_Project.Models;

namespace Final_Project.Pages.Tools
{
    public class EditModel : PageModel
    {
        private readonly Final_Tooling_Project.Models.ToolDbContext _context;
        [BindProperty]
        public Location Location { get; set; }= default!;

        public SelectList LocationDropDown {get; set; }= default!;

        public EditModel(Final_Tooling_Project.Models.ToolDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Tool Tool { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tool =  await _context.Tools.FirstOrDefaultAsync(m => m.ToolId == id);
            if (tool == null)
            {
                return NotFound();
            }
            Tool = tool;

            // Populate the LocationDropDown
            var locations = await _context.Locations.ToListAsync();
            LocationDropDown = new SelectList(locations, "LocationId", "LocationDesc");


            return Page();
        }
        

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

                    // Retrieve the selected LocationId from the dropdown
                         int selectedLocationId = Location.LocationId; 
                    // Find the Location entity based on the selected LocationId
                        var selectedLocation = await _context.Locations.FindAsync(selectedLocationId);
                    // Assign the selected Location to the Tool
                        Tool.Location = selectedLocation;

            _context.Entry(Tool).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ToolExists(Tool.ToolId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ToolExists(int id)
        {
            return _context.Tools.Any(e => e.ToolId == id);
        }
    }
}
