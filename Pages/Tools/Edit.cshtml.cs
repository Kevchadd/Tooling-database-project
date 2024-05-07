using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Final_Tooling_Project.Models;

<<<<<<< HEAD
=======

>>>>>>> b095c936b59145ddc7e69e25af179a5b882dbe42
namespace Final_Project.Pages.Tools
{
    public class EditModel : PageModel
    {
        private readonly Final_Tooling_Project.Models.ToolDbContext _context;

<<<<<<< HEAD
        public EditModel(Final_Tooling_Project.Models.ToolDbContext context)
        {
            _context = context;
=======
        [BindProperty]
        public Location? Location {get; set;} = default!;
       
        public EditModel(Final_Tooling_Project.Models.ToolDbContext context)
        {
            _context = context;
      
>>>>>>> b095c936b59145ddc7e69e25af179a5b882dbe42
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
<<<<<<< HEAD
            return Page();
=======
             
             Location = await _context.Locations.FirstOrDefaultAsync(l => l.ToolId == Tool.ToolId);
             if (Location == null)
             {
                 return NotFound(); 
             }   

                

         
            return Page();

           
>>>>>>> b095c936b59145ddc7e69e25af179a5b882dbe42
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Tool).State = EntityState.Modified;

<<<<<<< HEAD
            try
            {
=======
            try{

             if(Location !=null)

             {
                    _context.Update(Location);
             }
            // Update the tool location in the database
            
>>>>>>> b095c936b59145ddc7e69e25af179a5b882dbe42
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
<<<<<<< HEAD
}
=======
}
>>>>>>> b095c936b59145ddc7e69e25af179a5b882dbe42
