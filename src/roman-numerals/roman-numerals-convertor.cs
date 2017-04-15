using System;

namespace RomanNumerals
{
  public class RomanNumeralsConvertor
  {
    public string FromInt(int arabic)
    {
      string romanNumerals = string.Empty;
      for (int i = 1; i <= arabic; i++)
      {
        romanNumerals += "I";
      }

      return romanNumerals;
    }
  }
}
