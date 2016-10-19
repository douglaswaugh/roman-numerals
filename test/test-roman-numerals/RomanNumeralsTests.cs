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

            if (remainder >= 10) {
                var numberOfTens = Math.Floor(((decimal)(remainder / 10)));
                for (var i = numberOfTens; i > 0; i--){
                    numerals += "X";
                    remainder = remainder - 10;
                }
            }
            if (remainder == 9) {
                numerals = "IX";
                remainder = remainder - 9;
            }
            if (remainder >= 5) {
                numerals = "V";
                remainder = remainder - 5;
            }
            if (remainder == 4) {
                numerals += "IV";
                remainder = remainder - 4;
            }
            if (remainder > 0 && remainder <=3) {
                for (var i = remainder; i > 0; i--) {
                    numerals += "I";
                }
            }
            return numerals;
        }
    }
}