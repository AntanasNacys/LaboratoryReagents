using LaboratoryReagents.DL.Models;
using System.Collections.Generic;
using System.Data.Entity;

namespace LaboratoryReagents.DL
{
    class ReagentContextInitializer : CreateDatabaseIfNotExists<ReagentContext>
    {
        protected override void Seed(ReagentContext context)
        {
            List<ReagentName> reagentNames = new List<ReagentName>
            {
                new ReagentName {Name = "Nickel(II) chloride hexahydrate, kg"},
                new ReagentName {Name = "Sodium nitrite, kg" },
                new ReagentName {Name = "Sodium hydroxide, kg"},
                new ReagentName {Name = "Oxalic acid, kg"},
                new ReagentName {Name = "Titanium(IV) oxide, kg"},
                new ReagentName {Name = "Potassium nitrate, kg"},
                new ReagentName {Name = "Sodium molybdate dihydrate, kg "},
                new ReagentName {Name = "Ammonium molybdate tetraHydrate, kg"},
                new ReagentName {Name = "Sodium nitrate, kg"},
                new ReagentName {Name = "Ammmonium sulfate, kg"},
                new ReagentName {Name = "Zink nitrate hexahydrate, kg"},
                new ReagentName {Name = "Nickel(II) nitrate hexahydrate, kg"},
                new ReagentName {Name = "Sodium carbonate, kg"},
                new ReagentName {Name = "Borane-morpholine complex, 97%, l"},
                new ReagentName {Name = "Potassium chloride solution, l"},
                new ReagentName {Name = "Sulfuric acid, l"},
                new ReagentName {Name = "Phosphoric acid, l"},
                new ReagentName {Name = "Sodium borohydride, kg"},
                new ReagentName {Name = "Hydrazine hydrate, kg"},
                new ReagentName {Name = "Acetone, l"},
                new ReagentName {Name = "Tin(II) chloride dihydrate, kg"},


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
            List<User> users = new List<User>
            {
                new User {Username = "AntanasN", Password = "AntanasN123", IsAdmin = true,},
                new User {Username = "AldonaB", Password = "AldonaB123", IsAdmin = false,},
                new User {Username = "ZitaS", Password = "ZitaS123", IsAdmin = false,},
                new User {Username = "AusraZ", Password = "AusraZ123", IsAdmin = false,},
                new User {Username = "LoretaT", Password = "LoretaT123", IsAdmin = false,},
                new User {Username = "EugenijusN", Password = "EugenijusN123", IsAdmin = false,},
                new User {Username = "VirginijaK", Password = "VirginijaK123", IsAdmin = false,},
                new User {Username = "IrenaS", Password = "IrenaS123", IsAdmin = false,},
                new User {Username = "DainaU", Password = "DainaU123", IsAdmin = false,},
                new User {Username = "RamintaS", Password = "RamintaS123", IsAdmin = false,},
                new User {Username = "JolitaJ123", Password = "JolitaJ123", IsAdmin = false,},
                new User {Username = "TeofiliusK", Password = "TeofiliusK123", IsAdmin = false,},
            };
            context.ReagentNames.AddRange(reagentNames);
            context.Locations.AddRange(locations);
            context.Users.AddRange(users);

            //List<ReagentEntry> reagentEntries = new List<ReagentEntry>();
            //reagentNames.ForEach(x => reagentEntries.Add(new ReagentEntry { ReagentName = x, Comments = "", Location = locations[0], Quantity = 5 }));
            //context.ReagentEntries.AddRange(reagentEntries);
        }
    }
}