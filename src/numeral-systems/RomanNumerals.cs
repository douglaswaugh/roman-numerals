namespace NumeralSystems
{
    public class RomanNumerals
    {
        public string GetNumeralsFor(int numberToConvert)
        {
            if (numberToConvert == 0)
                return string.Empty;

            var numerals = string.Empty;
            var remainder = numberToConvert;

            return new RomanNumeralsBuilder(remainder, numerals)
                .ReplaceNumberWithNumerals(10, "X")
                .ReplaceNumberWithNumerals(9, "IX")
                .ReplaceNumberWithNumerals(5, "V")
                .ReplaceNumberWithNumerals(4, "IV")
                .ReplaceNumberWithNumerals(1, "I")
                .Numerals;
        }
    }
}