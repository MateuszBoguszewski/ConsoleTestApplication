using System;

namespace ConsoleTestApplication
{
    public class Shop
    {
        public double CreateDiscount(int quantity, int price)
        {
            if (price < 10)
            {
                return 0;
            }

            if (price < 30)
            {
                return quantity > 0 ? quantity * 0.1 : 0;
            }

            if (price < 50)
            {
                return quantity > 0 ? quantity * 0.15 + 5 : 0;
            }

            if (price < 100)
            {
                return quantity > 0 ? quantity * 0.2 + 10 : 0;
            }

            return quantity > 0 ? quantity * 0.25 + 15 : 0;
        }

        public object CreateDiscount(object quantity, object price)
        {
            throw new NotImplementedException();
        }

        public object CreateDiscount(object quantity, int price)
        {
            throw new NotImplementedException();
        }

        public static object CreateDiscount()
        {
            throw new NotImplementedException();
        }
    }
}
