using LaboratoryReagents.DL;
using LaboratoryReagents.DL.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace LaboratoryReagents.BL.Services
{
    public class ReagentEntryManager : IReagentEntryManager
    {
        public int AddEntry(ReagentEntry entry)
        {
            int entryKey;
            using (var ctx = new ReagentContext())
            {
                ctx.ReagentEntries.Add(entry);
                ctx.SaveChanges();
                entryKey = entry.ReagentId;
            }
            return entryKey;
        }

        public void DeleteEntry(int entryKey)
        {
            ReagentEntry entry;
            using (var ctx = new ReagentContext())
            {
                entry = ctx.ReagentEntries.Find(entryKey);
                ctx.ReagentEntries.Remove(entry);
                ctx.SaveChanges();
            }
        }

        public void UpdateEntry(ReagentEntry entry)
        {
            using (var ctx = new ReagentContext())
            {
                ReagentEntry oldEntry = ctx.ReagentEntries.Find(entry.ReagentId);
                if (oldEntry == null) return;
                ctx.Entry(oldEntry).CurrentValues.SetValues(entry);
                ctx.SaveChanges();
            }
        }

        public ReagentEntry GetReagent(int entryKey)
        {
            ReagentEntry entry;
            using (var ctx = new ReagentContext())
            {
                entry = ctx.ReagentEntries
                    .Where(x => x.ReagentId == entryKey)
                    .Include(x => x.ReagentName)
                    .Include(x => x.Location)
                    .FirstOrDefault();
            }
            return entry;
        }

        public List<ReagentEntry> GetAllReagents()
        {
            List<ReagentEntry> reagentEntriesList;
            using (var ctx = new ReagentContext())
            {
                reagentEntriesList = ctx.ReagentEntries
                    .Include(x => x.ReagentName)
                    .Include(x => x.Location)
                    .ToList();
                
            }
            return reagentEntriesList;
        }
    }
}
