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
        public void ConvertNumberToRoman(int number, string expected)
        {
            var actual = romanNumeralConverter.Convert(number);

            actual.Should().Be(expected);
        }
    }
}
