using System.ComponentModel.DataAnnotations;

namespace Final_Tooling_Project.Models;


public class Location
{
    public int LocationId { get; set; }// Primary Key
    [Required]
    public string LocationDesc { get; set;} = string.Empty;//Location of tool


    [Required]
    [Display (Name = "Tool")]
    public int ToolId { get; set; } //Foreign Key linking location to Tool

    public Tool? Tool{ get; set; }// Navigation Property

}
