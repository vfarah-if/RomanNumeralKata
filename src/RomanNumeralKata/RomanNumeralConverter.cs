using System;
using System.Collections.Generic;
using System.Text;

namespace RomanNumeralKata
{
    public class RomanNumeralConverter
    {
        private readonly Dictionary<int, string> romanNumerals = new Dictionary<int, string>
        {
            {1, "I"},
            {4, "IV"},
            {5, "V"},
            {9, "IX"},
            {10, "X"},
            {40, "XL"},
        };

        public string Convert(int arabicNumber)
        {
            if (romanNumerals.ContainsKey(arabicNumber))
            {
                return romanNumerals[arabicNumber];
            }

            var result = new StringBuilder();
            while(arabicNumber >= 40)
            {
                result.Append("XL");
                arabicNumber -= 40;
            }

            while (arabicNumber >= 10)
            {
                result.Append("XL");
                arabicNumber -= 10;
            }

            while (arabicNumber >= 5)
            {
                result.Append("V");
                arabicNumber -= 5;
            }

            while (arabicNumber >= 4)
            {
                result.Append("IV");
                arabicNumber -= 4;
            }

            while (arabicNumber >= 1)
            {
                result.Append("I");
                arabicNumber -= 1;
            }

            return result.ToString();
        }
    }
}
