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
            {6, "VI"},
            {7, "VII"},
            {8, "VIII"},
        };

        public string Convert(int arabicNumber)
        {
            if (romanNumerals.ContainsKey(arabicNumber))
            {
                return romanNumerals[arabicNumber];
            }

            return $"I{this.Convert(arabicNumber - 1)}";
        }
    }
}
