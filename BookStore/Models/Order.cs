using System;
using System.Collections.Generic;

#nullable disable

namespace BookStore.Models
{
    public partial class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime? ShippedDate { get; set; }
        public int ShipId { get; set; }
        public string Address { get; set; }
        public int StatusId { get; set; }
        public int UserId { get; set; }

        public virtual Ship Ship { get; set; }
        public virtual Status Status { get; set; }
        public virtual User User { get; set; }
    }
}
