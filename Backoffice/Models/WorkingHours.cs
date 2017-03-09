using System;
using System.ComponentModel.DataAnnotations;

namespace Backoffice.Models
{
    public class WorkingHours
    {
        public int ID { get; set; }
        public int VenueID { get; set; }
        public DayOfWeek Day { get; set; }
        [MaxLength(5)]
        public string OpenTime { get; set; }
        [MaxLength(5)]
        public string CloseTime { get; set; }

        public virtual Venue Venue { get; set; }
    }
    
}