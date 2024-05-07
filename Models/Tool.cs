
<<<<<<< HEAD
using System.ComponentModel;
=======
>>>>>>> b095c936b59145ddc7e69e25af179a5b882dbe42
using System.ComponentModel.DataAnnotations;

namespace Final_Tooling_Project.Models
{

public class Tool
{
    public int ToolId { get; set; }// Primary Key

    [Required]
<<<<<<< HEAD
    [DisplayName("Tool Name")]
    public string ToolName { get; set;} = string.Empty;//Tool nomenclature

    [Required]
    [DisplayName("Tool Used on")]
    public string ToolClub {get; set;} = string.Empty;// Club tool used on

    [Required]
    [DisplayName("In Service?")]
    public bool InService { get; set;}//If tool is usable 

    
    [DisplayName("Location")]
     public int? LocationId { get; set; } //foreign key linking tools
    
    // Navigation property
    public Location? Location { get; set; } // Navigation property   


=======
    [Display(Name = "Tool Name")]
    public string ToolName { get; set;} = string.Empty;//Tool nomenclature

    [Required]
    [Display(Name ="Tool Used On")]

    public string ToolClub {get; set;} = string.Empty;// Club tool used on
   
    [Required]
    [Display(Name = "InService?")]
    public bool InService { get; set;}//If tool is usable 

    public List<Location> Locations { get; set;} = new List<Location>();
>>>>>>> b095c936b59145ddc7e69e25af179a5b882dbe42
}
}


