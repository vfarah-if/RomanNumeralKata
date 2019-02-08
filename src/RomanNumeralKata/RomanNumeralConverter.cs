using System;
using System.Collections.Generic;

namespace RomanNumeralKata
{
    public class RomanNumeralConverter
    {
        private readonly List<string> romanNumerals = new List<string>{"I", "II", "III"};

        public string Convert(int arabicNumber)
        {
            return romanNumerals[arabicNumber-1];
        }
    }
}
