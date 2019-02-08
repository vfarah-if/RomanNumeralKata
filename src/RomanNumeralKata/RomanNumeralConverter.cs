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
        };

        public string Convert(int arabicNumber)
        {
            if (romanNumerals.ContainsKey(arabicNumber))
            {
                return romanNumerals[arabicNumber];
            }

            if (arabicNumber > 40)
            {
                return $"XL{this.Convert(arabicNumber - 40)}";
            }

            if (arabicNumber > 10)
            {
                return $"X{this.Convert(arabicNumber - 10)}";
            }

            if (arabicNumber > 5)
            {
                return $"V{this.Convert(arabicNumber - 5)}";
            }
            return $"I{this.Convert(arabicNumber - 1)}";
        }
    }
}
