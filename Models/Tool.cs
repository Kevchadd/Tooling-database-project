
using System.ComponentModel.DataAnnotations;

namespace Final_Tooling_Project.Models
{

public class Tool
{
    public int ToolId { get; set; }// Primary Key

    [Required]
    [Display(Name = "Tool Name")]
    public string ToolName { get; set;} = string.Empty;//Tool nomenclature

    [Required]
    [Display(Name ="Tool Used On")]

    public string ToolClub {get; set;} = string.Empty;// Club tool used on
   
    [Required]
    [Display(Name = "InService?")]
    public bool InService { get; set;}//If tool is usable 

    public List<Location> Locations { get; set;} = new List<Location>();
}
}


