using NUnit.Framework;
using RomanNumerals;

namespace RomanNumeralsTests
{
  [TestFixture]
  public class RomanNumeralsConvertorTests
  {
    [TestCase(1, "I")]
    [TestCase(2, "II")]
    [TestCase(4, "IV")]
    [TestCase(5, "V")]
    [TestCase(10, "X")]
    [TestCase(15, "XV")]
    [TestCase(18, "XVIII")]
    [TestCase(20, "XX")]
    public void Should_return_roman_numeral_for_arabic(int arabic, string expectedRomanNumeral)
    {
      var romanNumeralsConvertor = new RomanNumeralsConvertor();

      var romanNumeral = romanNumeralsConvertor.FromInt(arabic);

      Assert.That(romanNumeral, Is.EqualTo(expectedRomanNumeral));
    }
  }
}