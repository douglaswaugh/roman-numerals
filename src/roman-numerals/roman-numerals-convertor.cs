using System;

namespace RomanNumerals
{
  public class RomanNumeralsConvertor
  {
    public string FromInt(int arabic)
    {
      string romanNumerals = string.Empty;

      var romanNumeralsBuilder = new RomanNumeralsBuilder(arabic, string.Empty);

      for (int i = romanNumeralsBuilder.Arabic; i >= 10; i = i - 10)
      {
        romanNumeralsBuilder = new RomanNumeralsBuilder(romanNumeralsBuilder.Arabic - 10, romanNumeralsBuilder.RomanNumerals + "X");
      }

      for (int i = romanNumeralsBuilder.Arabic; i >= 5; i = i - 5)
      {
        romanNumeralsBuilder = new RomanNumeralsBuilder(romanNumeralsBuilder.Arabic - 5, romanNumeralsBuilder.RomanNumerals + "V");
      }

      for (int i = romanNumeralsBuilder.Arabic; i >= 4; i = i -4)
      {
        romanNumeralsBuilder = new RomanNumeralsBuilder(romanNumeralsBuilder.Arabic - 4, romanNumeralsBuilder.RomanNumerals + "IV");
      }

      for (int i = romanNumeralsBuilder.Arabic; i >= 1; i = i - 1)
      {
        romanNumeralsBuilder = new RomanNumeralsBuilder(romanNumeralsBuilder.Arabic - 1, romanNumeralsBuilder.RomanNumerals + "I");
      }

      return romanNumeralsBuilder.RomanNumerals;
    }
  }

  public class RomanNumeralsBuilder
  {
    int _arabic;
    string _romanNumerals;

    public int Arabic { get { return _arabic; } }
    public string RomanNumerals { get { return _romanNumerals; } }

    public RomanNumeralsBuilder(int arabic, string romanNumerals)
    {
      _arabic = arabic;
      _romanNumerals = romanNumerals;
    }
  }
}
