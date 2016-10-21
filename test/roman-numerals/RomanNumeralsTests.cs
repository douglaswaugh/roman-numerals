using NumeralSystems;
using NUnit.Framework;

namespace TestRomanNumerals
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
        [TestCase(44, "XLIV")]
        [TestCase(88, "LXXXVIII")]
        [TestCase(101, "CI")]
        [TestCase(333, "CCCXXXIII")]
        public void Should_return_numerals_for_number(int number, string expectedNumerals)
        {
            var romanNumerals = new RomanNumerals();

            var numerals = romanNumerals.GetNumeralsFor(number);

            Assert.That(numerals, Is.EqualTo(expectedNumerals));
        }

        [TestCase(0, "")]
        [TestCase(1, "I")]
        [TestCase(2, "II")]
        [TestCase(4, "IV")]
        [TestCase(5, "V")]
        [TestCase(6, "VI")]
        [TestCase(8, "VIII")]
        // [TestCase(9, "IX")]
        [TestCase(10, "X")]
        [TestCase(20, "XX")]
        // [TestCase(29, "XXIX")]
        [TestCase(35, "XXXV")]
        // [TestCase(44, "XLIV")]
        [TestCase(88, "LXXXVIII")]
        [TestCase(101, "CI")]
        [TestCase(333, "CCCXXXIII")]
        public void Should_return_numerals_for_number_by_replace(int number, string expectedNumerals)
        {
            var romanNumerals = new RomanNumerals();

            var numerals = romanNumerals.GetNumeralsByReplace(number);

            Assert.That(numerals, Is.EqualTo(expectedNumerals));
        }
    }
}