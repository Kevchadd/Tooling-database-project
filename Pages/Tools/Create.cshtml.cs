using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Final_Tooling_Project.Models;

namespace Final_Project.Pages.Tools
{
    public class CreateModel : PageModel
{
    private readonly Final_Tooling_Project.Models.ToolDbContext _context;

    public CreateModel(Final_Tooling_Project.Models.ToolDbContext context)
    {
        _context = context;
    }

    public IActionResult OnGet()
    {
        PopulateLocationDropDown();
        return Page();
    }

    [BindProperty]
    public Tool Tool { get; set; } = new Tool();

    // Add SelectedLocationId property
    [BindProperty]
    public int SelectedLocationId { get; set; }

    public SelectList LocationDropDown { get; set; }

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            PopulateLocationDropDown(); // Repopulate the dropdown if there are validation errors
            return Page();
        }

        // Retrieve the selected location
        var selectedLocation = await _context.Locations.FindAsync(SelectedLocationId);
        if (selectedLocation == null)
        {
            ModelState.AddModelError(string.Empty, "Invalid location selection.");
            PopulateLocationDropDown(); // Repopulate the dropdown
            return Page();
        }

        // Associate the selected location with the tool
        Tool.Location = selectedLocation;

        // Add the tool to the context and save changes
        _context.Tools.Add(Tool);
        await _context.SaveChangesAsync();

        return RedirectToPage("./Index");
    }

    private void PopulateLocationDropDown()
    {
        var locations = _context.Locations.ToListAsync().Result;
        LocationDropDown = new SelectList(locations, "LocationId", "LocationDesc");
    }
}}