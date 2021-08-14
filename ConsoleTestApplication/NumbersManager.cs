using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleTestApplication
{
    public class NumbersManager : INumbersManager
    {
        public List<int> SortNumbers(List<int> numbers, bool ascending)
        {
            if (numbers.Any(n => n < 1))
                throw new Exception();

            if (ascending)
                return numbers.OrderBy(n => n).ToList();

            return numbers.OrderByDescending(n => n).ToList();
        }
    }
}
