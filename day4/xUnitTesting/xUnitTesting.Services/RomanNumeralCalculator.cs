using System;

namespace xUnitTesting.Services {

    public class RomanNumeralCalculator {
        private IParseRomanNumerals parser;
        private IAddNumbers adder;

        public RomanNumeralCalculator(IParseRomanNumerals parser, IAddNumbers adder) {
            this.parser = parser;
            this.adder = adder;
        }

        public int Add(string numeral1, string numeral2) {
            
            var int1 = parser.Parse(numeral1);
            var int2 = parser.Parse(numeral2);
            //var result = adder.Add(int1, int2);
            //return result;
            return (0);
        }

    }
}
