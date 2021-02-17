using LaboratoryReagents.DL.Models;

namespace LaboratoryReagents.BL.Services
{
    public interface IReagentNameManager
    {
        int AddReagentName(ReagentName nameEntry);
        void DeleteReagentName(int entryKey);
        ReagentName GetReagentName(int entryKey);
        void UpdateReagentName(ReagentName nameEntry);
    }
}