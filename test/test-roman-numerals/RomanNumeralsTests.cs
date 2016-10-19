using NUnit.Framework;

namespace RomanNumerals
{
    [TestFixture]
    public class RomanNumeralsTests
    {
        [Test]
        public void Should_return_empty_string_for_0()
        {
            var numerals = GetNumeralsFor(0);

            Assert.That(numerals, Is.EqualTo(string.Empty));
        }

        [Test]
        public void Should_return_I_for_1()
        {
            var numerals = GetNumeralsFor(1);

            Assert.That(numerals, Is.EqualTo("I"));
        }

        [Test]
        public void Should_return_II_for_2()
        {
            var numerals = GetNumeralsFor(2);

            Assert.That(numerals, Is.EqualTo("II"));
        }

        public string GetNumeralsFor(int number)
        {
            if (number > 0) {
                var numerals = string.Empty;
                for (var i = number; i > 0; i--) {
                    numerals += "I";
                }
                return numerals;
            }                

            return string.Empty;
        }
    }
}