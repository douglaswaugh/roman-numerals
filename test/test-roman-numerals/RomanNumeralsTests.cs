using NUnit.Framework;

namespace RomanNumerals
{
    [TestFixture]
    public class RomanNumeralsTests
    {
        [TestCase(0, "")]
        [TestCase(1, "I")]
        [TestCase(2, "II")]
        public void Should_return_numerals_for_number(int number, string expectedNumerals)
        {
            var numerals = GetNumeralsFor(number);

            Assert.That(numerals, Is.EqualTo(expectedNumerals));
        }

        public string GetNumeralsFor(int numberToConvert)
        {
            if (numberToConvert > 0) {
                var numerals = string.Empty;
                for (var i = numberToConvert; i > 0; i--) {
                    numerals += "I";
                }
                return numerals;
            }

            return string.Empty;
        }
    }
}