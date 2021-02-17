using LaboratoryReagents.DL;
using LaboratoryReagents.DL.Models;
using System.Data.Entity;
using System.Linq;

namespace LaboratoryReagents.BL.Services
{
    public class ReagentNameManager : IReagentNameManager
    {
        public int AddReagentName(ReagentName nameEntry)
        {
            int entryKey;
            using (var ctx = new ReagentContext())
            {
                ctx.ReagentNames.Add(nameEntry);
                ctx.SaveChanges();
                entryKey = nameEntry.ReagentNameId;
            }
            return entryKey;
        }
        public void DeleteReagentName(int entryKey)
        {
            ReagentName nameEntry;
            using (var ctx = new ReagentContext())
            {
                nameEntry = ctx.ReagentNames.Find(entryKey);
                ctx.ReagentNames.Remove(nameEntry);
                ctx.SaveChanges();
            }
        }
        public void UpdateReagentName(ReagentName nameEntry)
        {
            using (var ctx = new ReagentContext())
            {
                ctx.Entry(nameEntry).State = EntityState.Modified;
                ctx.SaveChanges();
            }
        }
        public ReagentName GetReagentName(int entryKey)
        {
            ReagentName nameEntry;
            using (var ctx = new ReagentContext())
            {
                nameEntry = ctx.ReagentNames
                    .Where(x => x.ReagentNameId == entryKey)
                    .FirstOrDefault();
            }
            return nameEntry;
        }
    }
}
