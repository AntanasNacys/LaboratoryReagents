using LaboratoryReagents.DL.Models;
using System.Collections.Generic;

namespace LaboratoryReagents.DL.InitialData
{
    public static class UserInitialData
    {
        private static List<User> DataSeed => new List<User>
        {
            new User {Username = "AntanasN", Password = "AntanasN123", IsAdmin = true,},
            new User {Username = "AldonaB", Password = "AldonaB123", IsAdmin = false,},
            new User {Username = "ZitaS", Password = "ZitaS123", IsAdmin = false,},
            new User {Username = "AusraZ", Password = "AusraZ123", IsAdmin = false,},
            new User {Username = "LoretaT", Password = "LoretaT123", IsAdmin = false,},
            new User {Username = "EugenijusN", Password = "EugenijusN123", IsAdmin = false,},
            new User {Username = "VirginijaK", Password = "VirginijaK123", IsAdmin = false,},
            new User {Username = "IrenaS", Password = "IrenaS123", IsAdmin = false,},
            new User {Username = "DainaU", Password = "DainaS123", IsAdmin = false,},
            new User {Username = "RamintaS", Password = "RamintaS123", IsAdmin = false,},
            new User {Username = "JolitaJ123", Password = "JolitaS123", IsAdmin = false,},
            new User {Username = "TeofiliusK", Password = "TeofiliusK", IsAdmin = false,},
        };

    }
}
