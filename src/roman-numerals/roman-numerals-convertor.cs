using System;

namespace RomanNumerals
{
  public class RomanNumeralsConvertor
  {
    public string FromInt(int arabic)
    {
      string romanNumerals = string.Empty;

      for (int i = arabic; i >= 10; i = i - 10)
      {
        romanNumerals += "X";
        arabic = i - 10;
      }

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

      for (int i = arabic; i >= 1; i--)
      {
        romanNumerals += "I";
      }

      return romanNumerals;
    }
  }
}
