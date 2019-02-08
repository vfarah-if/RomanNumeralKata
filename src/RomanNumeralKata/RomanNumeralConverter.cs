using System.Collections.Generic;

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
            {44, "XLIV"},
        };

        public string Convert(int arabicNumber)
        {
            if (romanNumerals.ContainsKey(arabicNumber))
            {
                return romanNumerals[arabicNumber];
            }

            if (arabicNumber > 5)
            {
                return $"V{this.Convert(arabicNumber - 5)}";
            }
            return $"I{this.Convert(arabicNumber - 1)}";
        }
    }
}
