using System;

namespace RomanNumerals
{
  public class RomanNumeralsConvertor
  {
    public string FromInt(int arabic)
    {
      return new RomanNumeralsBuilder(arabic, string.Empty)
        .UseNumeralInsteadOfNumber(10, "X")
        .UseNumeralInsteadOfNumber(5, "V")
        .UseNumeralInsteadOfNumber(4, "IV")
        .UseNumeralInsteadOfNumber(1, "I")
        .RomanNumerals;
    }
  }

  public class RomanNumeralsBuilder
  {
    int _remaining;
    string _romanNumerals;

    public string RomanNumerals { get {return _romanNumerals; } }

    public RomanNumeralsBuilder(int remaining, string romanNumerals)
    {
      _remaining = remaining;
      _romanNumerals = romanNumerals;
    }

    public RomanNumeralsBuilder UseNumeralInsteadOfNumber(int number, string numeral)
    {
      RomanNumeralsBuilder romanNumeralsBuilder = this;

      for (int i = _remaining; i >= number; i = i - number)
      {
        romanNumeralsBuilder = new RomanNumeralsBuilder(romanNumeralsBuilder._remaining - number, romanNumeralsBuilder._romanNumerals + numeral);
      }

      return romanNumeralsBuilder;
    }
  }
}
