
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
<<<<<<< HEAD
		public DbSet<Location> Locations {get; set;} = default!;
=======

        public DbSet<Location> Locations {get; set; } = default!;
>>>>>>> b095c936b59145ddc7e69e25af179a5b882dbe42
		
	}
}