using System;

namespace RomanNumerals
{
  public class RomanNumeralsConvertor
  {
    public string FromInt(int arabic)
    {
      string romanNumerals = string.Empty;
      for (int i = arabic; i >= 1; i--)
      {
        romanNumerals += "I";
      }

      return romanNumerals;
    }
  }
}
