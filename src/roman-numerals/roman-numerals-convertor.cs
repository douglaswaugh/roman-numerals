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
      romanNumeralsBuilder = ConvertArabicToNumerals(romanNumeralsBuilder, 5, "V");
      romanNumeralsBuilder = ConvertArabicToNumerals(romanNumeralsBuilder, 4, "IV");
      romanNumeralsBuilder = ConvertArabicToNumerals(romanNumeralsBuilder, 1, "I");

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
