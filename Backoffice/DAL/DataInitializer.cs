using System.Collections.Generic;
using Backoffice.Models;

namespace Backoffice.DAL
{
    public class DataInitializer:System.Data.Entity.DropCreateDatabaseIfModelChanges<DALContext>
    {
        protected override void Seed(DALContext context)
        {
            var categories = new List<Category>
            {
                new Category { Name="Restaurant" },
                new Category { Name="Event" },
                new Category { Name="Sport" }
            };

            categories.ForEach(c => context.Categories.Add(c));
            context.SaveChanges();

            var listingRegions = new List<ListingRegion>
            {
                new ListingRegion { Name="Beşiktaş" },
                new ListingRegion { Name="Şişli" },
                new ListingRegion { Name="Kadıköy" },
                new ListingRegion { Name="Beyoğlu" },
                new ListingRegion { Name="Taksim", ParentRegionID=4 },
                new ListingRegion { Name="Mecidiyeköy", ParentRegionID=2 }
            };

            listingRegions.ForEach(l => context.ListingRegions.Add(l));
            context.SaveChanges();
            /*
            var venues = new List<Venue>
            {
                new Venue { Title="Dem Moda", Description="", Address="", FacebookUrl="", CategoryID=1, ConfirmedBy=1, }
            }*/
            
        }
    }
}