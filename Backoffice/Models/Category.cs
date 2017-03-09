using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Backoffice.Models
{
    public class Category
    {
        public int ID { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }

        public virtual ICollection<Venue> Venues { get; set; }
    }
}