using LaboratoryReagents.DL.Models;
using System.Collections.Generic;

namespace LaboratoryReagents.BL.Services
{
    public interface IReagentEntryManager
    {
        int AddEntry(ReagentEntry entry);
        void DeleteEntry(int entryKey);
        List<ReagentEntry> GetAllReagents();
        ReagentEntry GetReagent(int entryKey);
        void UpdateEntry(ReagentEntry entry);
    }
}