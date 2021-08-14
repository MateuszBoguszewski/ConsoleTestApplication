using ConsoleTestApplication;
using NUnit.Framework;

namespace MyTestProject
{
    class ShopTests
    {
    

        [Test]
        public void LessThanTenMin()
        {
            var shop = new Shop();
            var actual = shop.CreateDiscount(1,1);
            var excpect = 0;
            Assert.AreEqual(excpect, actual);
        }

        public void LessThanTenMax()
        {
            var shop = new Shop();
            var actual = shop.CreateDiscount(1, 9);
            var excpect = 0;
            Assert.AreEqual(excpect, actual);
        }

        [Test]
        public void BetweenTenAndTwentyNineMin()
        {
            var shop = new Shop();
            var actual = shop.CreateDiscount(2, 10);
            var excpect = 0.2;
            Assert.AreEqual(excpect, actual);
        }

        [Test]
        public void BetweenTenAndTwentyNineMax()
        {
            var shop = new Shop();
            var actual = shop.CreateDiscount(8, 29);
            var excpect = 0.8;
            Assert.AreEqual(excpect, actual);
        }

        [Test]
        public void BetweenThirtyAndFourtyNineMin()
        {
            var shop = new Shop();
            var actual = shop.CreateDiscount(4, 30);
            var excpect = 5.6;
            Assert.AreEqual(excpect, actual);
        }

        [Test]
        public void BetweenThirtyAndFourtyNineMax()
        {
            var shop = new Shop();
            var actual = shop.CreateDiscount(3, 49);
            var excpect = 5.45;
            Assert.AreEqual(excpect, actual);
        }

        [Test]
        public void BetweenFiftyAndNintyNineMin()
        {
            var shop = new Shop();
            var actual = shop.CreateDiscount(4, 50);
            var excpect = 10.8;
            Assert.AreEqual(excpect, actual);
        }

        [Test]
        public void BetweenFiftyAndNintyNineMax()
        {
            var shop = new Shop();
            var actual = shop.CreateDiscount(4, 99);
            var excpect = 10.8;
            Assert.AreEqual(excpect, actual);
        }

        [Test]
        public void MoreThanOneHundredMin()
        {
            var shop = new Shop();
            var actual = shop.CreateDiscount(5, 101);
            var excpect = 16.25;
            Assert.AreEqual(excpect, actual);
        }

        [Test]
        public void MoreThanOneHundredMax()
        {
            var shop = new Shop();
            var actual = shop.CreateDiscount(5, 2000);
            var excpect = 16.25;
            Assert.AreEqual(excpect, actual);
        }
    }
}
