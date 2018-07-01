using System.Security.AccessControl;

namespace BasketDiscount.Models
{
    public class Voucher
    {
        public string Name { get; set; }

        public VoucherType VoucherType { get; set; }

        public decimal Amount { get; set; }
    }
}
