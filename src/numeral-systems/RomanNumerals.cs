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
                .ReplaceNumberWithNumerals(100, "C")
                .ReplaceNumberWithNumerals(50, "L")
                .ReplaceNumberWithNumerals(40, "XL")
                .ReplaceNumberWithNumerals(10, "X")
                .ReplaceNumberWithNumerals(9, "IX")
                .ReplaceNumberWithNumerals(5, "V")
                .ReplaceNumberWithNumerals(4, "IV")
                .ReplaceNumberWithNumerals(1, "I")
                .Numerals;
        }

        public string GetNumeralsByReplace(int numberToConvert)
        {
            var numerals = new string('I', numberToConvert);

            return numerals
                .Replace("IIIII", "V")
                .Replace("VV", "X")
                .Replace("XXXXX", "L");
        }
    }
}