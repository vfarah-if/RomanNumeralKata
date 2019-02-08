using System;

namespace RomanNumeralKata
{
    public class RomanNumeralConverter
    {
        public string Convert(int arabicNumber)
        {
            return arabicNumber == 1 ? "I" : "II";
        }
    }
}
