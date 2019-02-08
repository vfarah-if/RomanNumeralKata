using System.Collections.Generic;

namespace RomanNumeralKata
{
    public class ArabicNumeralConverter
    {
        private readonly Dictionary<string, int> arabicNumerals = new Dictionary<string, int>
        {
            { "I", 1 },
            { "IV", 4 },
        };
        public int Convert(string romanNumber)
        {
            if (arabicNumerals.ContainsKey(romanNumber))
            {
                return arabicNumerals[romanNumber];
            }            
            return 1+Convert(romanNumber.Remove(0, 1));
        }
    }
}
