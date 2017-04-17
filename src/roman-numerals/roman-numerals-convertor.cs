using System;

namespace RomanNumerals
{
  public class RomanNumeralsConvertor
  {
    public string FromInt(int arabic)
    {
      string romanNumerals = string.Empty;

      var romanNumeralsBuilder = new RomanNumeralsBuilder(arabic, string.Empty);

      romanNumeralsBuilder = ConvertArabicToNumerals(romanNumeralsBuilder, 10, "X");

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

    private RomanNumeralsBuilder ConvertArabicToNumerals(RomanNumeralsBuilder romanNumeralsBuilder, int arabic, string numeral)
    {
      for (int i = romanNumeralsBuilder.Arabic; i >= arabic; i = i - arabic)
      {
        romanNumeralsBuilder = new RomanNumeralsBuilder(romanNumeralsBuilder.Arabic - arabic, romanNumeralsBuilder.RomanNumerals + numeral);
      }

      return romanNumeralsBuilder;
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
