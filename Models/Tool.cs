
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Final_Tooling_Project.Models
{

public class Tool
{
    public int ToolId { get; set; }// Primary Key

    [Required]
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


}
}


