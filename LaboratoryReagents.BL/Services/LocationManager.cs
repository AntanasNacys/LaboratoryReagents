using LaboratoryReagents.DL;
using LaboratoryReagents.DL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoryReagents.BL.Services
{
    public class LocationManager : ILocationManager
    {
        public List<Location> GetAll()
        {
            List<Location> locationsList;
            using (var ctx = new ReagentContext())
            {
                locationsList = ctx.Locations
                    .ToList();

            }
            return locationsList;
        }
        public Location GetByLocation(string location)
        {
            Location locationEntity;
            using (var context = new ReagentContext())
            {
                locationEntity = context.Locations.Where(z => z.LocationName == location).FirstOrDefault();
            }
            return locationEntity;
        }
    }
}
