using System;
using FluentAssertions;
using Xunit;

namespace RomanNumeralKata.UnitTests
{
    public class RomanConverterShould
    {
        private readonly RomanNumeralConverter romanNumeralConverter;

        public RomanConverterShould()
        {
            romanNumeralConverter = new RomanNumeralConverter();
        }

        [Theory]
        [InlineData(1, "I")]
        [InlineData(2, "II")]
        [InlineData(3, "III")]
        [InlineData(4, "IV")]
        [InlineData(5, "V")]
        [InlineData(6, "VI")]
        [InlineData(7, "VII")]
        [InlineData(8, "VIII")]
        [InlineData(9, "IX")]
        [InlineData(10, "X")]
        [InlineData(40, "XL")]
        [InlineData(44, "XLIV")]
        [InlineData(49, "XLIX")]
        [InlineData(50, "L")]
        [InlineData(90, "XC")]
        [InlineData(70, "LXX")]
        [InlineData(100, "C")]
        [InlineData(103, "CIII")]
        [InlineData(400, "CD")]
        [InlineData(500, "D")]
        [InlineData(846, "DCCCXLVI")]
        [InlineData(900, "CM")]
        [InlineData(1000, "M")]        
        [InlineData(1999, "MCMXCIX")]
        [InlineData(2008, "MMVIII")]
        public void ConvertNumberToRoman(int number, string expected)
        {
            var actual = romanNumeralConverter.Convert(number);

            actual.Should().Be(expected);
        }
    }
}
