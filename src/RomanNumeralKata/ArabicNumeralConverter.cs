namespace RomanNumeralKata
{
    public class ArabicNumeralConverter
    {
        public int Convert(string romanNumber)
        {
            if (romanNumber.Equals("I"))
            {
                return 1;
            }

            return 2;
        }
    }
}
