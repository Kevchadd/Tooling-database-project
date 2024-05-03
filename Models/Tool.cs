
namespace Final_Tooling_Project.Models
{

public class Tool
{
    public int ToolId { get; set; }// Primary Key
    public string ToolName { get; set;} = string.Empty;//Tool nomenclature

    public string ToolClub {get; set;} = string.Empty;// Club tool used on

    public bool InService { get; set;}//If tool is usable 
}
}


