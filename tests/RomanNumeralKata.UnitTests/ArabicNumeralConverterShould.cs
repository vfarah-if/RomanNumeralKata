﻿using FluentAssertions;
using Xunit;

namespace RomanNumeralKata.UnitTests
{
    public class ArabicNumeralConverterShould
    {
        private ArabicNumeralConverter arabicNumeralCoverter;

        public ArabicNumeralConverterShould()
        {
            arabicNumeralCoverter = new ArabicNumeralConverter();
        }

        [Theory]
        [InlineData("I", 1)]
        [InlineData("II", 2)]
        [InlineData("III", 3)]
        [InlineData("IV", 4)]
        [InlineData("V", 5)]
        [InlineData("VI", 6)]
        [InlineData("VII", 7)]
        [InlineData("VIII", 8)]
        [InlineData("IX", 9)]
        [InlineData("X", 10)]
        [InlineData("XL", 40)]
        [InlineData("XLIV", 44)]
        [InlineData("XLIX", 49)]
        [InlineData("L", 50)]
        [InlineData("XC", 90)]
        [InlineData("C", 100)]
        [InlineData("CIII", 103)]
        [InlineData("CD", 400)]
        [InlineData("D", 500)]
        [InlineData("DCCCXLVI", 846)]
        [InlineData("CM", 900)]
        [InlineData("M", 1000)]
        [InlineData("MCMXCIX", 1999)]
        [InlineData("MMVIII", 2008)]
        public void ConvertRomanNumeralToArabic(string romanNumber, int expected)
        {
            var actual = arabicNumeralCoverter.Convert(romanNumber);

            actual.Should().Be(expected);
        }
    }
}
