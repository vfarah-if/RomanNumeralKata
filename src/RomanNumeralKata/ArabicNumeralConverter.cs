using System.Collections.Generic;

namespace RomanNumeralKata
{
    public class ArabicNumeralConverter
    {
        private readonly Dictionary<string, int> arabicNumerals = new Dictionary<string, int>
        {
            { "I", 1 },
            { "IV", 4 },
            { "V", 5 },
            { "IX", 9 },
            { "X", 10 },
            { "XL", 40 },
            { "L", 50 },
            { "XC", 90 },
            { "C", 100 },
        };
        public int Convert(string romanNumber)
        {
            if (arabicNumerals.ContainsKey(romanNumber))
            {
                return arabicNumerals[romanNumber];
            }

            if (romanNumber.StartsWith("L"))
            {
                return 50 + Convert(romanNumber.Substring(2));
            }

            if (romanNumber.StartsWith("XL"))
            {
                return 40 + Convert(romanNumber.Substring(2));
            }

            if (romanNumber.StartsWith("X"))
            {
                return 10 + Convert(romanNumber.Substring(2));
            }

            if (romanNumber.StartsWith("V"))
            {
                return 5 + Convert(romanNumber.Substring(1));
            }

            return 1 + Convert(romanNumber.Remove(0, 1));
        }
    }
}
