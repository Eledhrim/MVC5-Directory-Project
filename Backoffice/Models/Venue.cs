using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backoffice.Models
{
    public class Venue
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Website { get; set; }
        public float Lat { get; set; }
        public float Long { get; set; }
        public string VideoUrl { get; set; }
        public string FacebookUrl { get; set; }
        public string TwitterUrl { get; set; }
        public string YoutubeUrl { get; set; }
        public string PinterestUrl { get; set; }
        public int SubmittedByID { get; set; }
        public int ConfirmedByID { get; set; }
        public int CategoryID { get; set; }
        public int ListingRegionID { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<WorkingHours> WorkingHours { get; set; }
        public virtual ListingRegion ListingRegion { get; set; }
        public virtual ICollection<Image> Images { get; set; }

       

    }
}