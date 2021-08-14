using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTestApplication
{
    public class MyClass
    {
        public string myText { get; set; }
        public int myInt { get; set; }

        public string ShowText(int a, string b)
        {
            for (int i = 0; i < a; i++)
            {
                b += "A";
            }
            return b;
        }
    }
}
