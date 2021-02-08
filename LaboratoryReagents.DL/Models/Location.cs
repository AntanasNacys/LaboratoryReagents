using System.ComponentModel.DataAnnotations;

namespace LaboratoryReagents.DL.Models
{
    public class Location
    {
        [Key]
        public int LocationId { get; set; }
        public string LocationName { get; set; }
    }
}
