using System;
using System.Collections.Generic;

#nullable disable

namespace PRN_ProjectBookStore.Models
{
    public partial class Product
    {
        public Product()
        {
            Bills = new HashSet<Bill>();
        }

        public string Pid { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string Catid { get; set; }
        public string Image { get; set; }

        public virtual Category Cat { get; set; }
        public virtual Cart Cart { get; set; }
        public virtual ICollection<Bill> Bills { get; set; }
    }
}
