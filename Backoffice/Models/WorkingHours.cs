using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backoffice.Models
{
    public class WorkingHours
    { 
        public int VenueID { get; set; }
        public DayOfWeek Day { get; set; }
        public string OpenTime { get; set; }
        public string CloseTime { get; set; }

        public virtual Venue Venue { get; set; }
    }
    
}