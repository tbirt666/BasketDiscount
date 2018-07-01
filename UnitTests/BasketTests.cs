using System;
using System.Collections.Generic;
using BasketDiscount;
using BasketDiscount.Models;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class BasketTests
    {
        public IBasketService BasketService { get; set; }

        [SetUp]
        public void SetUp()
        {
            BasketService = new BasketService();
        }

        [TearDown]
        public void TearDown()
        {
            BasketService = null;
        }

        [Test]
        public void Basket1Test()
        {
            
            // arrange
            var basket1TestData = new Basket()
            {
                Id = Guid.NewGuid(),
                Name = "Basket 1",
                BasketItems = new List<BasketItem>()
                {
                    new BasketItem()
                    {
                        Name = "Hat",
                        Quantity = 1,
                        Price = 25.00m,
                    },
                    new BasketItem()
                    {
                        Name = "Jumper",
                        Quantity = 1,
                        Price = 26.00m
                    }

                }
            };

            var testVoucher = new Voucher()
            {
                Name = "XXX-XXX",
                VoucherType = VoucherType.Gift,
                Amount = 5.00m

            };

            // act 
            var result = BasketService.ApplyVoucher(basket1TestData, testVoucher);

            // assert
            //Assert.IsTrue(result);
            Assert.AreEqual(60.15m, basket1TestData.Total);
            Assert.AreEqual("1 x £5.00 Gift Voucher XXX-XXX applied", basket1TestData.Message);
        }
    }
}
