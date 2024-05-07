using Microsoft.EntityFrameworkCore;

namespace Final_Tooling_Project.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
                using (var context = new ToolDbContext(
                    serviceProvider.GetRequiredService<DbContextOptions<ToolDbContext>>()))
                {

                    // Look for any locations.
                if (context.Locations.Any())
                {
                    return; // DB has been seeded
                }

                // Seed locations
                var locations = new List<Location>
                {
                    new Location { LocationDesc = "Building 1" },
                    new Location { LocationDesc = "Building 2" },
                    new Location { LocationDesc = "Building 3" },
                    new Location { LocationDesc = "Building 4" }
                };

                context.Locations.AddRange(locations);
                context.SaveChanges();



                // Look for any blogs.
                if (context.Tools.Any())
                {
                    return; // DB has been seeded
                }
            
                context.Tools.AddRange(
                    new Tool
                    {
                        ToolName = "Screwdriver 1",
                        ToolClub = "Wedge",                        
                        InService = false,
                        LocationId = locations[0].LocationId // Assign to Building 1
                    }
                    ,
                     new Tool
                    {
                        ToolName = "Screwdriver 2",
                        ToolClub = "8 iron",
                        InService = true,
                         LocationId = locations[2].LocationId // Assign to Building 3

                    }
                ,
                     new Tool
                    {
                        ToolName = "Screwdriver 3",
                        ToolClub = "Putter",
                        InService = true,
                        LocationId = locations[0].LocationId // Assign to Building 1

                    }
                    ,
                     new Tool
                    {
                        ToolName = "Screwdriver 4",
                        ToolClub = "6 iron",
                        InService = true,
                        LocationId = locations[2].LocationId // Assign to Building 3

                    },
                      new Tool
                    {
                        ToolName = "Screwdriver 5",
                        ToolClub = "Driver",
                        InService = false,
                        LocationId = locations[3].LocationId // Assign to Building 4

                    },
                       new Tool
                    {
                        ToolName = "Scale 1",
                        ToolClub = "Driver",                        
                        InService = true,
                        LocationId = locations[3].LocationId // Assign to Building 4
                    }
                    ,
                     new Tool
                    {
                        ToolName = "Scale 2",
                        ToolClub = "Putter",
                        InService = true,
                        LocationId = locations[0].LocationId // Assign to Building 1

                    }
                ,
                     new Tool
                    {
                        ToolName = "Scale 3",
                        ToolClub = "Wedge",
                        InService = true,
                        LocationId = locations[3].LocationId // Assign to Building 4

                        }
                    ,
                     new Tool
                    {
                        ToolName = "Scale 4",
                        ToolClub = "9 iron",
                        InService = false,
                        LocationId = locations[0].LocationId // Assign to Building 1
                        

                    },
                      new Tool
                    {
                        ToolName = "Scale 5",
                        ToolClub = "6 iron",
                        InService = true,
                        LocationId = locations[2].LocationId // Assign to Building 3

                    },
                     new Tool
                    {
                        ToolName = "Press 1",
                        ToolClub = "5 iron",                        
                        InService = true,
                        LocationId = locations[3].LocationId // Assign to Building 4
                    }
                    ,
                     new Tool
                    {
                        ToolName = "Press 2",
                        ToolClub = "9 iron",
                        InService = true,
                        LocationId = locations[0].LocationId // Assign to Building 1

                    }
                ,
                     new Tool
                    {
                        ToolName = "Press 3",
                        ToolClub = "Putter",
                        InService = true,
                        LocationId = locations[3].LocationId // Assign to Building 4

                    }
                    ,
                     new Tool
                    {
                        ToolName = "Press 4",
                        ToolClub = "Driver",
                        InService = true,
                        LocationId = locations[1].LocationId // Assign to Building 2

                    },
                      new Tool
                    {
                        ToolName = "Press 5",
                        ToolClub = "Wedge",
                        InService = false,
                        LocationId = locations[3].LocationId // Assign to Building 4

                    },
                     new Tool
                    {
                        ToolName = "Depth gauge 1",
                        ToolClub = "5 iron",                        
                        InService = true,
                        LocationId = locations[1].LocationId // Assign to Building 2
                    }
                    ,
                     new Tool
                    {
                        ToolName = "Depth gauge 2",
                        ToolClub = "9 iron",
                        InService = true,
                        LocationId = locations[2].LocationId // Assign to Building 3

                    }
                ,
                     new Tool
                    {
                        ToolName = "Depth gauge 3",
                        ToolClub = "Putter",
                        InService = true,
                        LocationId = locations[3].LocationId // Assign to Building 4

                    }
                    ,
                     new Tool
                    {
                        ToolName = "Depth gauge 4",
                        ToolClub = "Driver",
                        InService = true,
                        LocationId = locations[1].LocationId // Assign to Building 2

                    },
                      new Tool
                    {
                        ToolName = "Depth gauge 5",
                        ToolClub = "Wedge",
                        InService = true,
                        LocationId = locations[0].LocationId // Assign to Building 1

                    },
                     new Tool
                    {
                        ToolName = "Bench Vise 1",
                        ToolClub = "5 iron",                        
                        InService = true,
                        LocationId = locations[1].LocationId // Assign to Building 2
                    }
                    ,
                     new Tool
                    {
                        ToolName = "Bench Vise 2",
                        ToolClub = "9 iron",
                        InService = true,
                        LocationId = locations[2].LocationId // Assign to Building 3

                    }
                ,
                     new Tool
                    {
                        ToolName = "Bench Vise 3",
                        ToolClub = "Putter",
                        InService = true,
                        LocationId = locations[3].LocationId // Assign to Building 4

                    }
                    ,
                     new Tool
                    {
                        ToolName = "Bench Vise 4",
                        ToolClub = "Driver",
                        InService = true,
                        LocationId = locations[3].LocationId // Assign to Building 4

                    },
                      new Tool
                    {
                        ToolName = "Bench Vise 5",
                        ToolClub = "Wedge",
                        InService = true,
                        LocationId = locations[1].LocationId // Assign to Building 2

                    }

                );
                    
                
                context.SaveChanges();
            }
        }
    }
}