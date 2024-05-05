

namespace Final_Tooling_Project.Models;


public class Course
{
    public int LocationId { get; set; }// Primary Key
    public string LocationDesc { get; set;} = string.Empty;//Location of tool

    public int ToolID { get; set; } //Foreign Key linking location to Tool

    public Tool? Tool{ get; set; }// Navigation Property

}
