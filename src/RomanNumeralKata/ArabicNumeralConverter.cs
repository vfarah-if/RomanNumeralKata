﻿using System.Collections.Generic;

namespace RomanNumeralKata
{
    public class ArabicNumeralConverter
    {
        private readonly Dictionary<string, int> arabicNumerals = new Dictionary<string, int>
        {
            { "MM", 2000},
            { "M", 1000},
            { "CM", 900},
            { "D", 500},
            { "CD", 400},
            { "C", 100 },
            { "XC", 90 },
            { "L", 50 },
            { "XL", 40 },
            { "X", 10 },
            { "IX", 9 },
            { "V", 5 },
            { "IV", 4 },
            { "I", 1 },
        };
        public int Convert(string romanNumber)
        {
            int result = 0;

            foreach (var arabicNumeral in arabicNumerals)
            {
                if (romanNumber.StartsWith(arabicNumeral.Key))
                {
                    result += arabicNumeral.Value;
                    romanNumber = romanNumber.Substring(arabicNumeral.Key.Length);
                }
            }

            while (!string.IsNullOrEmpty(romanNumber))
            {
                result += 1;
                romanNumber = romanNumber.Substring(1);
            }

            return result;
        }
    }
}
