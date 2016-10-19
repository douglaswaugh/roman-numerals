using System;
using NUnit.Framework;

namespace RomanNumerals
{
    [TestFixture]
    public class RomanNumeralsTests
    {
        [TestCase(0, "")]
        [TestCase(1, "I")]
        [TestCase(2, "II")]
        [TestCase(4, "IV")]
        [TestCase(5, "V")]
        [TestCase(6, "VI")]
        [TestCase(8, "VIII")]
        [TestCase(9, "IX")]
        [TestCase(10, "X")]
        [TestCase(20, "XX")]
        [TestCase(29, "XXIX")]
        [TestCase(35, "XXXV")]
        [TestCase(44, "XXXXIV")]
        public void Should_return_numerals_for_number(int number, string expectedNumerals)
        {
            var numerals = GetNumeralsFor(number);

            Assert.That(numerals, Is.EqualTo(expectedNumerals));
        }

        public string GetNumeralsFor(int numberToConvert)
        {
            if (numberToConvert == 0)
                return string.Empty;

            var numerals = string.Empty;
            var remainder = numberToConvert;

            return new RomanNumeralsBuilder(remainder, numerals)
                .ReplaceNumberWithNumerals(10, "X")
                .ReplaceNumberWithNumerals(9, "IX")
                .ReplaceNumberWithNumerals(5, "V")
                .ReplaceNumberWithNumerals(4, "IV")
                .ReplaceNumberWithNumerals(1, "I")
                .Numerals;
        }
    }

    public class RomanNumeralsBuilder
    {
        int _remainder;
        string _numerals;

        public RomanNumeralsBuilder (int remainder, string numerals)
        {
          _remainder = remainder;
          _numerals = numerals;
        }

        public int Remainder {
            get { return _remainder; }
        }

        public string Numerals {
            get { return _numerals; }
        }

        public RomanNumeralsBuilder ReplaceNumberWithNumerals(int number, string numeral)
        {
            var numerals = _numerals;
            var remainder = _remainder;
            for (var i = Math.Floor(((decimal)(_remainder / number))); i > 0; i--){
                if (_remainder >= number) {
                    numerals = numerals + numeral;
                    remainder = remainder - number;
                }
            }

            return new RomanNumeralsBuilder(remainder, numerals);
        }
    }
}