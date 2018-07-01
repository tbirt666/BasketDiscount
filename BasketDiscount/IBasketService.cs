using BasketDiscount.Models;

namespace BasketDiscount
{
    public interface IBasketService
    {
        bool ApplyVoucher(Basket basket, Voucher voucher);
    }
}
