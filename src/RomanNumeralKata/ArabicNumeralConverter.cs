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
            { "X", 10 },
            { "XL", 40 },
        };
        public int Convert(string romanNumber)
        {
            if (arabicNumerals.ContainsKey(romanNumber))
            {
                return arabicNumerals[romanNumber];
            }

            if (romanNumber.StartsWith("XL"))
            {
                return 40 + Convert(romanNumber.Substring(2));
            }

            if (romanNumber.EndsWith("X"))
            {
                return 10 - Convert(romanNumber.Substring(0, romanNumber.Length - 1));
            }

            if (romanNumber.StartsWith("V"))
            {
                return 5 + Convert(romanNumber.Substring(1));
            }

            return 1 + Convert(romanNumber.Remove(0, 1));
        }
    }
}
