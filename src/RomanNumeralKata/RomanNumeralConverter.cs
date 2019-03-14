using System.Collections.Generic;
using System.Text;

namespace RomanNumeralKata
{
    public class RomanNumeralConverter
    {
        private readonly Dictionary<int, string> romanNumerals = new Dictionary<int, string>
        {
            {1000, "M"},
            {900, "CM"},
            {500, "D"},
            {400, "CD"},
            {100, "C"},
            {90, "XC"},
            {50, "L"},
            {40, "XL"},
            {10, "X"},
            {9, "IX"},
            {5, "V"},
            {4, "IV"},
            {1, "I"},
        };

        public string Convert(int arabicNumber)
        {
            if (romanNumerals.ContainsKey(arabicNumber))
            {
                return romanNumerals[arabicNumber];
            }

            var result = new StringBuilder();
            foreach (var romanNumeral in romanNumerals)
            {
                while (arabicNumber >= romanNumeral.Key)
                {
                    result.Append(romanNumeral.Value);
                    arabicNumber -= romanNumeral.Key;
                }
            }
          
            return result.ToString();
        }
    }
}
