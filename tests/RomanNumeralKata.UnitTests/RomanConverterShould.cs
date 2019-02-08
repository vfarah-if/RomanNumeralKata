using System;
using System.Collections.Generic;
using System.Text;
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
        public void ConvertNumberToRoman(int number, string expected)
        {
            var actual = romanNumeralConverter.Convert(number);

            actual.Should().Be(expected);
        }
    }
}
