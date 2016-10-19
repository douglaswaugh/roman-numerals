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

        // put the right number of numerals in 
        // pass on the remainder

        // something to do with the base ten-ness; multiples of 1's, 10's, 100's, etc. can exist, but not the other numbers

        public string GetNumeralsFor(int numberToConvert)
        {
            if (numberToConvert == 0)
                return string.Empty;

            var numerals = string.Empty;
            var remainder = numberToConvert;

            var builder = new RomanNumeralsBuilder(remainder, numerals);
            for (var i = Math.Floor(((decimal)(remainder / 10))); i > 0; i--){
                builder = builder.ReplaceNumberWithNumeral(10, "X");
            }            
            builder = builder.ReplaceNumberWithNumeral(9, "IX");
            builder = builder.ReplaceNumberWithNumeral(5, "V");
            builder = builder.ReplaceNumberWithNumeral(4, "IV");
            for (var i = Math.Floor(((decimal)(remainder / 1))); i > 0; i--) {
                builder = builder.ReplaceNumberWithNumeral(1, "I");
            }
            return builder.Numerals;
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

        public RomanNumeralsBuilder ReplaceNumberWithNumeral(int number, string numeral)
        {
            if (_remainder >= number) {
                var numerals = _numerals + numeral;
                var remainder = _remainder - number;
                return new RomanNumeralsBuilder(remainder, numerals);
            }
            return this;
        }
    }
}