using LaboratoryReagents.BL.Models;
using LaboratoryReagents.DL.Models;
using System.Collections.Generic;

namespace LaboratoryReagents.BL.Services
{
    public interface IReagentUIViewManager
    {
        List<ReagentUIView> GetAll();
        List<ReagentUIView> GetReagentsByLocation(Location location);
        List<ReagentUIView> GetReagentsByName(ReagentName reagentName);
    }
}