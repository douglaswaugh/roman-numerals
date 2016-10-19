using System;

namespace NumeralSystems
{
    public class RomanNumeralsBuilder
    {
        int _remainder;
        string _numerals;

        public RomanNumeralsBuilder (int remainder, string numerals)
        {
          _remainder = remainder;
          _numerals = numerals;
        }

        public int Remainder {
            get { return _remainder; }
        }

        public string Numerals {
            get { return _numerals; }
        }

        public RomanNumeralsBuilder ReplaceNumberWithNumerals(int number, string numeral)
        {
            var numerals = _numerals;
            var remainder = _remainder;
            for (var i = Math.Floor(((decimal)(_remainder / number))); i > 0; i--){
                if (_remainder >= number) {
                    numerals = numerals + numeral;
                    remainder = remainder - number;
                }
            }

            return new RomanNumeralsBuilder(remainder, numerals);
        }
    }
}