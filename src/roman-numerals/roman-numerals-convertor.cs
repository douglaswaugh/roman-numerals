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
}
