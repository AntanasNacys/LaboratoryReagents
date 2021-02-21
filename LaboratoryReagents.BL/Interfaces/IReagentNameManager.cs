using LaboratoryReagents.DL.Models;
using System.Collections.Generic;

namespace LaboratoryReagents.BL.Services
{
    public interface IReagentNameManager
    {
        int AddReagentName(ReagentName nameEntry);
        void DeleteReagentName(int entryKey);
        List<ReagentName> GetAll();
        ReagentName GetByName(string reagentName);
        ReagentName GetReagentName(int entryKey);
        void UpdateReagentName(ReagentName nameEntry);
    }
}