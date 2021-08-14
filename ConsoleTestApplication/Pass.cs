using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleTestApplication
{
    public class Pass
    {
        public bool Numbers { get; set; }
        public bool SpecialCharacter { get; set; }
        public int SmallLetters { get; set; }
        public int BigLetters { get; set; }
        public IRandomize _randomize;
        public Pass(IRandomize randomize, bool numbers, bool specialCharacters, int smallLetters, int bigLetters)
        {
            Numbers = numbers;
            SpecialCharacter = specialCharacters;
            SmallLetters = smallLetters;
            BigLetters = bigLetters;
            _randomize = randomize;
        }
        public bool CheckPassword()
        {
            var match = Regex.Match(_randomize.RandomPassword(Numbers, SpecialCharacter,SmallLetters,BigLetters), @"^((?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*\W).{8,})$");
            if (!match.Success)
            {
                return false;
            }
            return true;
        }
    }
}
