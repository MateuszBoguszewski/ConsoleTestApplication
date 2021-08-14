using ConsoleTestApplication;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyTestProject
{
    class OrderTests
    {

        [Test]
        public void CreateProduct()
        {
            var product1 = new Product(1, "marchewka", 5);
            Assert.IsTrue(product1.Id == 1 && product1.Name == "marchewka" && product1.Price == 5);
        }

        [Test]
        public void CreateOrderPosition()
        {
            var product1 = new Product(1, "marchewka", 5);
            var orderPosition = new OrderPosition(1, product1, 5);
            Assert.IsTrue(orderPosition.Id == 1 && orderPosition.Product.Id == 1 && orderPosition.Product.Name == "marchewka" && orderPosition.Product.Price == 5 && orderPosition.Quantity == 5);
        }

        [Test]
        public void CreateOrder()
        {
            var product1 = new Product(1, "marchewka", 5);
            var product2 = new Product(2, "pietruszka", 3);

            var orderPosition1 = new OrderPosition(1, product1, 5);
            var orderPosition2 = new OrderPosition(2, product2, 3);

            var orderPositions = new List<OrderPosition>();

            orderPositions.Add(orderPosition1);
            orderPositions.Add(orderPosition2);

            var order1 = new Order(1, orderPositions);
            Assert.IsTrue(order1.Id == 1 && order1.OrderPositions.Any(op => op.Id == 1 &&  op.Product.Id == 1 &&  op.Product.Name == "marchewka" && op.Product.Price == 5 && op.Quantity == 5) && order1.Price == 34 && order1.CretatedDate == DateTime.Today &&
                 order1.OrderPositions.Any(op => op.Id == 2 && op.Product.Id == 2 && op.Product.Name == "pietruszka" && op.Product.Price == 3 && op.Quantity == 3));
        }
    }
}
