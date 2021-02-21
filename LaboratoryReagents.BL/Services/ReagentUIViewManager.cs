using LaboratoryReagents.BL.Models;
using LaboratoryReagents.DL.Models;
using System.Collections.Generic;
using System.Linq;

namespace LaboratoryReagents.BL.Services
{
    public class ReagentUIViewManager : IReagentUIViewManager
    {

        public ReagentEntryManager reagentEntryManager;

        public ReagentUIViewManager()
        {
            reagentEntryManager = new ReagentEntryManager();
        }
        public List<ReagentUIView> GetReagentsByName(string reagentName)
        {
            List<ReagentUIView> reagentUIViews = new List<ReagentUIView>();
            List<ReagentEntry> reagentEntries = reagentEntryManager
                .GetAllReagents()
                .Where(x => x.ReagentName.Name == reagentName)
                .ToList();

            foreach (var reagentEntry in reagentEntries)
            {
                ReagentUIView reagentUIView = new ReagentUIView();
                reagentUIView.ReagentId = reagentEntry.ReagentId;
                reagentUIView.ReagentName = reagentEntry.ReagentName.Name.ToString();
                reagentUIView.DateTime = reagentEntry.InsertionDate.ToString("yyyy-MM-dd");
                reagentUIView.Quantity = reagentEntry.Quantity;
                reagentUIView.Comments = reagentEntry.Comments;
                reagentUIView.Location = reagentEntry.Location.LocationName.ToString();
                reagentUIViews.Add(reagentUIView);
            }
            return reagentUIViews.OrderBy(z => z.ReagentName).ToList();


        }
        public List<ReagentUIView> GetReagentsByLocation(string location)
        {
            List<ReagentUIView> reagentUIViews = new List<ReagentUIView>();
            List<ReagentEntry> reagentEntries = reagentEntryManager
                .GetAllReagents()
                .Where(x => x.Location.LocationName == location)
                .ToList();

            foreach (var reagentEntry in reagentEntries)
            {
                ReagentUIView reagentUIView = new ReagentUIView();
                reagentUIView.ReagentId = reagentEntry.ReagentId;
                reagentUIView.ReagentName = reagentEntry.ReagentName.Name.ToString();
                reagentUIView.DateTime = reagentEntry.InsertionDate.ToString("yyyy-MM-dd");
                reagentUIView.Quantity = reagentEntry.Quantity;
                reagentUIView.Comments = reagentEntry.Comments;
                reagentUIView.Location = reagentEntry.Location.LocationName.ToString();
                reagentUIViews.Add(reagentUIView);
            }
            return reagentUIViews.OrderBy(z => z.Location).ToList();

        }

        public List<ReagentUIView> GetAll()
        {
            List<ReagentUIView> reagentUIViews = new List<ReagentUIView>();
            List<ReagentEntry> reagentEntries = reagentEntryManager.GetAllReagents();

            foreach (var reagentEntry in reagentEntries)
            {
                ReagentUIView reagentUIView = new ReagentUIView();
                reagentUIView.ReagentId = reagentEntry.ReagentId;
                reagentUIView.ReagentName = reagentEntry.ReagentName.Name.ToString();
                reagentUIView.DateTime = reagentEntry.InsertionDate.ToString("yyyy-MM-dd");
                reagentUIView.Quantity = reagentEntry.Quantity;
                reagentUIView.Comments = reagentEntry.Comments;
                reagentUIView.Location = reagentEntry.Location.LocationName.ToString();
                reagentUIViews.Add(reagentUIView);
            }
            return reagentUIViews.OrderBy(z => z.ReagentName).ToList();
        }


    }
}
