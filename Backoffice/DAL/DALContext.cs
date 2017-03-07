using Backoffice.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Backoffice.DAL
{
    public class DALContext:DbContext
    {
        public DALContext():base("DefaultConnection")
        {}

        public DbSet<Venue> Venues { get; set; } //Entityset = db table, entity = db row
        public DbSet<WorkingHours> WorkingHours { get; set; }
        public DbSet<ListingRegion> ListingRegions { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>(); //prevent db table names from being pluralized

            //base.OnModelCreating(modelBuilder);
        }
    }
}