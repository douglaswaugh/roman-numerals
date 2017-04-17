using System;
using System.Collections.Generic;

namespace RomanNumerals
{
  public class RomanNumeralsConvertor
  {
    private List<KeyValuePair<int, string>> _conversions;

    public RomanNumeralsConvertor(List<KeyValuePair<int, string>> conversions)
    {
      _conversions = conversions;
    }

    public string FromInt(int arabic)
    {
      var romanNumeralsBuilder = new RomanNumeralsBuilder(arabic, string.Empty);

      foreach(var keyValuePair in _conversions)
      {
        romanNumeralsBuilder = romanNumeralsBuilder.UseNumeralInsteadOfNumber(keyValuePair.Key, keyValuePair.Value);
      }

      return romanNumeralsBuilder.RomanNumerals;
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
