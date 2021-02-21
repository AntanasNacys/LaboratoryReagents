using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LaboratoryReagents.DL.Models
{
    [Table("ReagentEntries")]
    public class ReagentEntry
    {
        [Key]
        public int ReagentId { get; set; }
        public int ReagentNameId { get; set; }
        public DateTime InsertionDate { get; set; }
        public virtual ReagentName ReagentName { get; set; }
        public int LocationId { get; set; }
        public virtual Location Location { get; set; }
        public int Quantity { get; set; }
        [MaxLength(50)]
        public string Comments { get; set; }
    }
}
