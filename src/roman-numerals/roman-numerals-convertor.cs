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

      arabic = romanNumeralsBuilder.Arabic;
      romanNumerals = romanNumeralsBuilder.RomanNumerals;

      for (int i = arabic; i >= 5; i = i - 5)
      {
        romanNumerals += "V";
        arabic = i - 5;
      }

      for (int i = arabic; i >= 4; i = i -4)
      {
        romanNumerals += "IV";
        arabic = i - 4;
      }

      for (int i = arabic; i >= 1; i = i - 1)
      {
        romanNumerals += "I";
      }

      return romanNumerals;
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
