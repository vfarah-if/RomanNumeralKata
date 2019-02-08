using System.Collections.Generic;

namespace RomanNumeralKata
{
    public class ArabicNumeralConverter
    {
        private readonly Dictionary<string, int> arabicNumerals = new Dictionary<string, int>
        {
            { "I", 1 },
            { "II", 2 },
            { "III", 3 },

        };
        public int Convert(string romanNumber)
        {
            return arabicNumerals[romanNumber];
        }
    }
}
