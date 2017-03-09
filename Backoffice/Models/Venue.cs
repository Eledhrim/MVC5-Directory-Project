using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Backoffice.Models
{
    public class Venue
    {
        public int ID { get; set; }
        [MaxLength(50)]
        public string Title { get; set; }
        public string Description { get; set; }
        [MaxLength(500)]
        public string Address { get; set; }
        [MaxLength(20)]
        [Phone]
        public string Phone1 { get; set; }
        [MaxLength(20)]
        [Phone]
        public string Phone2 { get; set; }
        [MaxLength(100)]
        [Url]
        public string Website { get; set; }
        
        public float Lat { get; set; }
        public float Long { get; set; }
        [MaxLength(100)]
        [Url]
        public string VideoUrl { get; set; }
        [MaxLength(100)]
        [Url]
        public string FacebookUrl { get; set; }
        [MaxLength(100)]
        [Url]
        public string TwitterUrl { get; set; }
        [MaxLength(100)]
        [Url]
        public string YoutubeUrl { get; set; }
        [MaxLength(100)]
        [Url]
        public string PinterestUrl { get; set; }
        public int SubmittedBy { get; set; }
        public int ConfirmedBy { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public System.DateTime SubmitDate { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public System.DateTime ConfirmDate { get; set; }
        public int CategoryID { get; set; }
        public int ListingRegionID { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<WorkingHours> WorkingHours { get; set; }
        public virtual ListingRegion ListingRegion { get; set; }
        public virtual ICollection<Image> Images { get; set; }

       

    }
}