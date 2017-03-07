using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backoffice.Models
{
    public class Image
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Caption { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string FileName { get; set; }
        public int VenueID { get; set; }

        public virtual Venue Venue { get; set; }
    }
}