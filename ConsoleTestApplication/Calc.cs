using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTestApplication
{
    public class Calc
    {
        public int Number1 { get; set; }
        public int Number2 { get; set; }
        public int Number3 { get; set; }
        public int Number4 { get; set; }

        public IRandomize Randomize1;
        public IRandomize Randomize2;

        public Calc(int number1, int number2, int number3, int number4, IRandomize randomize1, IRandomize randomize2)
        {
            Number1 = number1;
            Number2 = number2;
            Number3 = number3;
            Number4 = number4;
            Randomize1 = randomize1;
            Randomize2 = randomize2;
        }

        public int Add()
        {
            return Randomize1.RandomNumber(Number1, Number2) + Randomize2.RandomNumber(Number3, Number4);
        }
        public int Substruct()
        {
            return Randomize1.RandomNumber(Number1, Number2) - Randomize2.RandomNumber(Number3, Number4);
        }
        public int Multiply()
        {
            return Randomize1.RandomNumber(Number1, Number2) *  Randomize2.RandomNumber(Number3, Number4);
        }
        public float Divide()
        {
            try
            {
                return Randomize1.RandomNumber(Number1, Number2) / Randomize2.RandomNumber(Number3, Number4);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}