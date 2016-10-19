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

        public string GetNumeralsFor(int number)
        {
            return string.Empty;
        }
    }
}  