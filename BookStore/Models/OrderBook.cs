using System;
using System.Collections.Generic;

#nullable disable

namespace BookStore.Models
{
    public partial class OrderBook
    {
        public int OrderId { get; set; }
        public int BookId { get; set; }
        public int Quantity { get; set; }

        public virtual Book Book { get; set; }
        public virtual Order Order { get; set; }
    }
}
