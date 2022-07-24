using System;
using System.Collections.Generic;

#nullable disable

namespace BookStore.Models
{
    public partial class Ship
    {
        public Ship()
        {
            Orders = new HashSet<Order>();
        }

        public int ShipId { get; set; }
        public string ShipCompany { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
