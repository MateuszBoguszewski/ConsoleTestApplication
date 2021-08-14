using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTestApplication
{
    public interface IRandomize
    {
        int RandomNumber(int min, int max);
        string RandomString(int size, bool lowerCase);
        string RandomPassword(bool numbers, bool specialCharacter, int smallLetters, int bigLetters);
    }
}
