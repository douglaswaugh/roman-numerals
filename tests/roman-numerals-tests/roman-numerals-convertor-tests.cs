using NUnit.Framework;
using RomanNumerals;

namespace RomanNumeralsTests
{
  [TestFixture]
  public class RomanNumeralsConvertorTests
  {
    [TestCase(1, "I")]
    [TestCase(2, "II")]
    public void Should_return_roman_numeral_for_arabic(int arabic, string expectedRomanNumeral)
    {
      var romanNumeralsConvertor = new RomanNumeralsConvertor();

      var romanNumeral = romanNumeralsConvertor.FromInt(arabic);

      Assert.That(romanNumeral, Is.EqualTo(expectedRomanNumeral));
    }
  }
}