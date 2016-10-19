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
            if (numberToConvert == 4) {
                var numberOfFives = Math.Floor(((decimal)numberToConvert / 4));
                numerals = "IV";
            }
            else if (numberToConvert <=3) {
                for (var i = numberToConvert; i > 0; i--) {
                    numerals += "I";
                }
            }
            return numerals;
        }
    }
}