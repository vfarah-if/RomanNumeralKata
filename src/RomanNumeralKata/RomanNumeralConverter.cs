using System.Collections.Generic;

namespace RomanNumeralKata
{
    public class RomanNumeralConverter
    {
        private readonly Dictionary<int, string> romanNumerals = new Dictionary<int, string>
        {
            {1, "I"},
            {2, "II"},
            {3, "III"},
            {4, "IV"}
        };

        public string Convert(int arabicNumber)
        {
            return romanNumerals[arabicNumber];
        }
    }
}
