
using Microsoft.Identity.Client;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Final_Tooling_Project.Models;


public class Location
{
    public int LocationId { get; set; }// Primary Key

    [DisplayName("Location")]
    public string LocationDesc { get; set;} = string.Empty;//Location of tool

    public int ToolID { get; set; } //Foreign Key linking location to Tool

    public List<Tool> Tools { get; set; } = new List<Tool>();// Naviagtion Property one location can have many tools

}
