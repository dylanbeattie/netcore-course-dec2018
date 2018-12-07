namespace xUnitTesting.Services {
    public class RomanNumeralParser : IParseRomanNumerals {
        public int Parse(string romanNumeral) {
            return 1;
        }
    }

    public interface IParseRomanNumerals {
        int Parse(string numeral);
    }
}
