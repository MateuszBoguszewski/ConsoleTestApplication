using System;

namespace ConsoleTestApplication
{
    public class FizzBuzzClass
    {
        public ICalculatorClass _calculatorClass;

        public int Number1 { get; set; } = 13;
        public int Number2 { get; set; } = 1;
        public FizzBuzzClass(ICalculatorClass calculatorClass, int number1, int number2)
        {
            _calculatorClass = calculatorClass;
            Number1 = number1;
            Number2 = number2;
        }
        public string CheckFizzBuzz()
        {
            var number1 = _calculatorClass.Add(Number1,Number2);
            var number2 = _calculatorClass.Substruct(Number1, Number2);
            var number3 = _calculatorClass.Multiply(Number1, Number2);

            if (number1 != 0 && number1 % 3 == 0 && number1 % 5 == 0)
            {
                return "FizzBuzz";
            }
            else if (number2 != 0 && number2 % 3 == 0)
            {
                return "Fizz";
            }
            else if (number3 != 0 && number3 % 5 == 0)
            {
                return "Buzz";
            }

            throw new Exception();
        }
    }
}
