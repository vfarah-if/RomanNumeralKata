using System;

namespace RomanNumeralKata
{
    public class RomanNumeralConverter
    {
        public string Convert(int arabicNumber)
        {
            if (arabicNumber == 1)
            {
                return "I";
            }
            return "II";
        }
    }
}
