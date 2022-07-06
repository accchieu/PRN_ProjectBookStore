using System;
using System.Collections.Generic;

#nullable disable

namespace PRN_ProjectBookStore.Models
{
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public string Catid { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
