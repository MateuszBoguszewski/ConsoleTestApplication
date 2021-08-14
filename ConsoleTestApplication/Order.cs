using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleTestApplication
{
    public class Order
    {
        public int Id { get; set; }
        public List<OrderPosition> OrderPositions { get; set; }
        public decimal Price { get; set; }
        public DateTime CretatedDate { get; set; }

        public Order(int id, List<OrderPosition> orderPositions)
        {
            Id = id;
            OrderPositions = orderPositions;
            Price = orderPositions.Sum(op => op.Quantity * op.Product.Price);
            CretatedDate = DateTime.Today;
        }
    }
}
