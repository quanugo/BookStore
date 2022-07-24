using System;
using System.Collections.Generic;

#nullable disable

namespace BookStore.Models
{
    public partial class Book
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime PublishedDate { get; set; }
        public double Price { get; set; }
        public string Genre { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
    }
}
