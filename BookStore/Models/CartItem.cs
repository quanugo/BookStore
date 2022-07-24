using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class CartItem
    {
        public int Quantity { set; get; }
        public Book Book { set; get; }

        public CartItem()
        {
        }

        public CartItem(int quantity, Book book)
        {
            this.Quantity = quantity;
            this.Book = book;
        }
    }
}
