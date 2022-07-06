using System;
using System.Collections.Generic;

#nullable disable

namespace PRN_ProjectBookStore.Models
{
    public partial class Account
    {
        public Account()
        {
            Bills = new HashSet<Bill>();
            Carts = new HashSet<Cart>();
        }

        public string Username { get; set; }
        public string Password { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int Role { get; set; }

        public virtual ICollection<Bill> Bills { get; set; }
        public virtual ICollection<Cart> Carts { get; set; }
    }
}
