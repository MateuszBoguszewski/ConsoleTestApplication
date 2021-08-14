using ConsoleTestApplication;
using NUnit.Framework;

namespace MyTestProject
{
    class ShopClassTests
    {
        [Test]
        public void LessThanTen()
        {
            var shop = new ShopClass(2, 5);
            var actual = shop.CreateDiscount();
            var expect = 0;

            Assert.AreEqual(actual, expect);
        }

        [Test]
        public void BetweenTenAndTwentyNineMin()
        {
            var shop = new ShopClass(2, 10);
            var actual = shop.CreateDiscount();
            var expect = 0.2;

            Assert.AreEqual(actual, expect);
        }

        [Test]
        public void BetweenTenAndTwentyNineMax()
        {
            var shop = new ShopClass(2, 29);
            var actual = shop.CreateDiscount();
            var expect = 0.2;

            Assert.AreEqual(actual, expect);
        }

        [Test]
        public void BetweenThirtyAndFourtyNineMin()
        {
            var shop = new ShopClass(2, 30);
            var actual = shop.CreateDiscount();
            var expect = 5.3;

            Assert.AreEqual(actual, expect);
        }

        [Test]
        public void BetweenThirtyAndFourtyNineMax()
        {
            var shop = new ShopClass(2, 49);
            var actual = shop.CreateDiscount();
            var expect = 5.3;

            Assert.AreEqual(actual, expect);
        }

        [Test]
        public void CreateShop()
        {
            var shop = new ShopClass(2, 50);
            Assert.IsTrue(shop.Quantity == 2 && shop.Price == 50);
        }     
    }
}
