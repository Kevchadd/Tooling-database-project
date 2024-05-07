
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;

namespace Final_Tooling_Project.Models

{
	public class ToolDbContext : DbContext
	{
		public ToolDbContext (DbContextOptions<ToolDbContext> options)
			: base(options)
		{
		}
		public DbSet<Tool> Tools {get; set;} = default!;

        public DbSet<Location> Locations {get; set; } = default!;
		
	}
}