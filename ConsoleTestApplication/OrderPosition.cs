using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTestApplication
{
    public class OrderPosition
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public OrderPosition(int id, Product product, int quantity)
        {
            Id = id;
            Product = product;
            Quantity = quantity;
        }
    }
}
