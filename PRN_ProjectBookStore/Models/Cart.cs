using System;
using System.Collections.Generic;

#nullable disable

namespace PRN_ProjectBookStore.Models
{
    public partial class Cart
    {
        public string Username { get; set; }
        public string Pid { get; set; }
        public int Amount { get; set; }

        public virtual Product PidNavigation { get; set; }
        public virtual Account UsernameNavigation { get; set; }
    }
}
