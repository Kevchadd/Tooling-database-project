<<<<<<< HEAD

using Microsoft.Identity.Client;
using System.ComponentModel;
=======
>>>>>>> b095c936b59145ddc7e69e25af179a5b882dbe42
using System.ComponentModel.DataAnnotations;

namespace Final_Tooling_Project.Models;


public class Location
{
    public int LocationId { get; set; }// Primary Key
<<<<<<< HEAD

    [DisplayName("Location")]
=======
    [Required]
>>>>>>> b095c936b59145ddc7e69e25af179a5b882dbe42
    public string LocationDesc { get; set;} = string.Empty;//Location of tool


    [Required]
    [Display (Name = "Tool")]
    public int ToolId { get; set; } //Foreign Key linking location to Tool

    public List<Tool> Tools { get; set; } = new List<Tool>();// Naviagtion Property one location can have many tools

}
