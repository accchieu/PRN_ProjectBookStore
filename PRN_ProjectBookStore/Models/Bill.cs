using System;
using System.Collections.Generic;

#nullable disable

namespace PRN_ProjectBookStore.Models
{
    public partial class Bill
    {
        public string Bid { get; set; }
        public string Username { get; set; }
        public string Pid { get; set; }
        public DateTime Date { get; set; }
        public int Amount { get; set; }
        public double Total { get; set; }

        public virtual Product PidNavigation { get; set; }
        public virtual Account UsernameNavigation { get; set; }
    }
}
