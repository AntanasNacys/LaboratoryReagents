using LaboratoryReagents.DL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoryReagents.DL
{
    public class ReagentContext : DbContext
    {
        public ReagentContext() : base("ReagentDB")
        {
            Database.SetInitializer(new ReagentContextInitializer());
        }

        public DbSet<ReagentEntry> ReagentEntries { get; set; }
        public DbSet<ReagentName> ReagentNames { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
