using LaboratoryReagents.BL.Models;
using LaboratoryReagents.DL.Models;
using System.Collections.Generic;

namespace LaboratoryReagents.BL.Services
{
    public interface IReagentUIViewManager
    {
        List<ReagentUIView> GetAll();
        List<ReagentUIView> GetReagentsByLocation(string location);
        List<ReagentUIView> GetReagentsByName(string reagentName);
    }
}