using LaboratoryReagents.DL.Models;
using System.Collections.Generic;

namespace LaboratoryReagents.BL.Services
{
    public interface ILocationManager
    {
        List<Location> GetAll();
        Location GetByLocation(string location);
    }
}