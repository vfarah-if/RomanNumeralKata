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

            int result = 0;            

            if (romanNumber.StartsWith("L"))
            {
                result += 50;
                romanNumber = romanNumber.Substring(2);
            }

            if (romanNumber.StartsWith("XL"))
            {
                result += 40;
                romanNumber = romanNumber.Substring(2);
            }

            if (romanNumber.StartsWith("X"))
            {
                result += 10;
                romanNumber = romanNumber.Substring(1);
            }

            if (romanNumber.StartsWith("IX"))
            {
                result += 9;
                romanNumber = romanNumber.Substring(2);
            }

            if (romanNumber.StartsWith("V"))
            {
                result += 5;
                romanNumber = romanNumber.Substring(1);
            }

            if (romanNumber.StartsWith("IV"))
            {
                result += 4;
                romanNumber = romanNumber.Substring(2);
            }

            while (!string.IsNullOrEmpty(romanNumber))
            {
                result += 1;
                romanNumber = romanNumber.Substring(1);
            }

            return result;
        }
    }
}
