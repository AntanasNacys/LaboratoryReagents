using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LaboratoryReagents.DL.Models
{
    [Table("Reagents")]
    public class ReagentEntry
    {
        [Key]
        public int ReagentId { get; set; }
        public int ReagentNameId { get; set; }
        public virtual ReagentName ReagentName { get; set; }
        public int LocationId { get; set; }
        public virtual Location Location { get; set; }
        public double Quantity { get; set; }
        public string Comments { get; set; }
       
    }
}
