namespace HealthBuddy
{
    using HealthBuddy.Migrations;
    using System;
    using System.Data.Entity;
    using System.Linq;

    using HealthBuddy.Models;

    public class HealthBuddyContext : DbContext
    {

        public HealthBuddyContext()
            : base("HealthBuddyContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<HealthBuddyContext, Configuration>());
            //  Database.SetInitializer(new DropCreateDatabaseAlways<HealthBuddyContext>());    

        }

        public virtual DbSet<Appetiser> Appetisers { get; set; }

        public virtual DbSet<Breakfast> Breakfasts { get; set; }

        public virtual DbSet<Dessert> Desserts { get; set; }

        public virtual DbSet<Liquid> Liquids { get; set; }

        public virtual DbSet<Main> Mains { get; set; }

        public virtual DbSet<Salad> Salads { get; set; }

        public virtual DbSet<Soup> Soups { get; set; }

    }
}