using NUnit.Framework;
using RomanNumerals;
using System.Collections.Generic;

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
      var conversions = new List<KeyValuePair<int, string>>
      {
        new KeyValuePair<int, string> (10, "X"),
        new KeyValuePair<int, string> (5, "V"),
        new KeyValuePair<int, string> (4, "IV"),
        new KeyValuePair<int, string> (1, "I"),
      };

      var romanNumeralsConvertor = new RomanNumeralsConvertor(conversions);

      var romanNumeral = romanNumeralsConvertor.FromInt(arabic);

      Assert.That(romanNumeral, Is.EqualTo(expectedRomanNumeral));
    }
  }
}