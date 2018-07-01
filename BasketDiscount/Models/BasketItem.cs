using System;

namespace BasketDiscount.Models
{
    public class BasketItem
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }
    }
}
