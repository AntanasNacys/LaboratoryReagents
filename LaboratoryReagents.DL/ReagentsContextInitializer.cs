using LaboratoryReagents.DL.Models;
using System.Collections.Generic;
using System.Data.Entity;

namespace LaboratoryReagents.DL
{
    class ReagentsContextInitializer : CreateDatabaseIfNotExists<ReagentsContext>
    {
        protected override void Seed(ReagentsContext context)
        {
            List<ReagentName> reagents = new List<ReagentName>
            {
                new ReagentName {Name = "Nickel(II) chloride hexahydrate"},
                new ReagentName {Name = "Sodium nitrite, kg" },
                new ReagentName {Name = "Sodium hydroxide"},
                new ReagentName {Name = "Oxalic acid"},
                new ReagentName {Name = "Titanium(IV) oxide"},
                new ReagentName {Name = "Potassium nitrate"},
                new ReagentName {Name = "Sodium molybdate dihydrate "},
                new ReagentName {Name = "Ammonium molybdate tetraHydrate"},
                new ReagentName {Name = "Sodium nitrate}"},
                new ReagentName {Name = "Ammmonium sulfate"},
                new ReagentName {Name = "Zink nitrate hexahydrate"},
                new ReagentName {Name = "Nickel(II) nitrate hexahydrate"},
                new ReagentName {Name = "Sodium carbonate"},
                new ReagentName {Name = "Borane-morpholine complex, 97%"},
                new ReagentName {Name = "Potassium chloride solution"},
                new ReagentName {Name = "Sulfuric acid"},
                new ReagentName {Name = "Phosphoric acid"},
                new ReagentName {Name = "Sodium borohydride"},
                new ReagentName {Name = "Hydrazine hydrate"},
                new ReagentName {Name = "Acetone"},
                new ReagentName {Name = "Tin(II) chloride dihydrate"},


            };
            List<Location> locations = new List<Location>
            {
                new Location {LocationName = "Warehouse"},
                new Location {LocationName = "E201"},
                new Location {LocationName = "E202"},
                new Location {LocationName = "E203"},
                new Location {LocationName = "E203"},
                new Location {LocationName = "E204"},
                new Location {LocationName = "E205"},
                new Location {LocationName = "E207"},

            };
        }
    }
}