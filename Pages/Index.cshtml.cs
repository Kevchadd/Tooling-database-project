using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Final_Tooling_Project.Models;

namespace Final_Project.Pages;

public class IndexModel : PageModel
{
    private readonly ToolDbContext _context;// Replaces the "db" variable from before
    private readonly ILogger<IndexModel> _logger;

     public List<Tool> Tools {get; set;} = default!;

    public IndexModel(ToolDbContext context,ILogger<IndexModel> logger)
    {
        _context = context;
        _logger = logger;
    }

    public void OnGet()
    {
        Tools = _context.Tools.ToList();
    }
}