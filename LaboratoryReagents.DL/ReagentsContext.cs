using LaboratoryReagents.DL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoryReagents.DL
{
    public class ReagentsContext : DbContext
    {
        public ReagentsContext() : base("ReagentDB")
        {
            Database.SetInitializer(new ReagentsContextInitializer());
        }
        public DbSet<ReagentEntry> Reagents { get; set; }
        public DbSet<ReagentName> ReagentNames { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
