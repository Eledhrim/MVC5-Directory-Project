using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backoffice.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Venue> Venues { get; set; }
    }
}