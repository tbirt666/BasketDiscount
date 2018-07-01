using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketDiscount.Models
{
    public class Basket
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public double Total { get; set; }

        public string Message { get; set; }

        public List<BasketItem> BasketItems { get; set; }
    }
}
