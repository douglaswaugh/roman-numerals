using NUnit.Framework;
using RomanNumerals;

namespace RomanNumeralsTests
{
  [TestFixture]
  public class RomanNumeralsConvertorTests
  {
    [Test]
    public void Should_return_I_for_1()
    {
      var romanNumeralsConvertor = new RomanNumeralsConvertor();

      var romanNumeral = romanNumeralsConvertor.FromInt(1);

      Assert.That(romanNumeral, Is.EqualTo("I"));
    }
  }
}