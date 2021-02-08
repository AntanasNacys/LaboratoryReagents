using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LaboratoryReagents.DL.Models
{
    public class ReagentName
    {
        [Key]
        public int ReagentNameId { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        public virtual List<ReagentEntry> ReagentEntries { get; set; }
    }
}
