using System.ComponentModel.DataAnnotations;

namespace Backoffice.Models
{
    public class Image
    {
        public int ID { get; set; }
        [MaxLength(50)]
        public string Title { get; set; }
        [MaxLength(250)]
        public string Caption { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        [MaxLength(50)]
        public string FileName { get; set; }
        public int VenueID { get; set; }

        public virtual Venue Venue { get; set; }
    }
}