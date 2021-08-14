using System.Collections.Generic;

namespace ConsoleTestApplication
{
    public class PrimeNumber
    {
        public INumbersManager _numbersManager;
        public List<int> Numbers { get; set; }
        public bool Ascending { get; set; }
        public QuantityNumbers QuantityPrimeNumbers { get; set; }

        public PrimeNumber(INumbersManager numbersManager, List<int> numbers, bool ascending, QuantityNumbers quantityPrimeNumbers)
        {
            _numbersManager = numbersManager;
            Numbers = numbers;
            Ascending = ascending;
            QuantityPrimeNumbers = quantityPrimeNumbers;
        }

        public QuantityNumbers CountNumbers()
        {
            var numbers = _numbersManager.SortNumbers(Numbers, Ascending);
            int primeNumbers = 0;
            int notPrimeNumbers = 0;

            foreach (var n in numbers)
            {
                if (CheckPrimeNumber(n))
                {
                    primeNumbers++;
                }
                else
                {
                    notPrimeNumbers++;
                }
            }

            QuantityPrimeNumbers = new QuantityNumbers(primeNumbers, notPrimeNumbers);
            return QuantityPrimeNumbers;
        }

        private bool CheckPrimeNumber(int number)
        {
            if (number < 2)
                return false;

            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
    }
}
