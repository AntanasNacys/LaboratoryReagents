using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoryReagents.BL.Models
{
    public class ReagentUIView
    {
        public int ReagentId { get; set; }

        public string ReagentName { get; set; }
        public string DateTime { get; set; }
        public int Quantity { get; set; }
        public string Comments { get; set; }

        public string Location { get; set; }
    }
}
