namespace RomanNumerals 
{
  public class RomanNumeralsBuilder
  {
    private readonly int _remaining;
    private readonly string _romanNumerals;

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
        var remaining = romanNumeralsBuilder._remaining - number;
        var numerals = romanNumeralsBuilder._romanNumerals + numeral
        romanNumeralsBuilder = new RomanNumeralsBuilder(remaining, numerals);
      }

      return romanNumeralsBuilder;
    }
  }
}