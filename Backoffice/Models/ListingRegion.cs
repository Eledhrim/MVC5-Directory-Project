using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Backoffice.Models
{
    public class ListingRegion
    {
        public int ID { get; set; }
        public string Name { get; set; }
        [DisplayFormat(NullDisplayText = "Main Category")]
        public int? ParentRegionID { get; set; }

        public virtual ListingRegion ParentRegion { get; set; }
        public virtual ICollection<Venue> Venues { get; set; }

    }
}