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
        };
        public int Convert(string romanNumber)
        {
            if (arabicNumerals.ContainsKey(romanNumber))
            {
                return arabicNumerals[romanNumber];
            }

            if (romanNumber.StartsWith("V"))
            {
                return 5 + Convert(romanNumber.Substring(1, romanNumber.Length-1));
            }
            return 1+Convert(romanNumber.Remove(0, 1));
        }
    }
}
