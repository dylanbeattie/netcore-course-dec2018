using Moq;
using Shouldly;
using System;
using Xunit;
using xUnitTesting.Services;

namespace xUnitTesting.UnitTests {
    public class CalculatorTests {
        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(0, 1, 1)]
        [InlineData(1, 2, 3)]
        [InlineData(3, 5, 8)]
        public void Add(int input1, int input2, int expected) {
            var calc = new Calculator();
            var result = calc.Add(input1, input2);
            result.ShouldBe(expected);
        }
    }

    public class RomanNumeralParserTests {
        [Theory]
        [InlineData("I", 1)]
        public void ParseSingleDigit(string input, int expected) {
            var p = new RomanNumeralParser();
            var result = p.Parse(input);
            result.ShouldBe(expected);
        }

    }

    public class RomanNumeralCalculatorTests {
        [Theory]
        [InlineData("I", "I")]
        [InlineData("I", "II")]
        [InlineData("V", "X")]
        public void CalculatorParsesFirstArgument(string n1, string n2) {
            var mockParser = new Mock<IParseRomanNumerals>();
            var mockAdder = new Mock<IAddNumbers>();
            mockParser.Setup(p => p.Parse(n1)).Verifiable();
            var rnc = new RomanNumeralCalculator(mockParser.Object, mockAdder.Object);
            rnc.Add(n1, n2);
            mockParser.Verify();
        }

        [Theory]
        [InlineData("I", "I")]
        [InlineData("I", "II")]
        [InlineData("V", "X")]
        public void CalculatorParsesSecondArgument(string n1, string n2) {
            var mockParser = new Mock<IParseRomanNumerals>();
            var mockAdder = new Mock<IAddNumbers>();
            mockParser.Setup(p => p.Parse(n2));
            var rnc = new RomanNumeralCalculator(mockParser.Object, mockAdder.Object);
            rnc.Add(n1, n2);
            mockParser.Verify();
        }

        [Fact]
        public void CalculatorAddsArguments() {
            var mockParser = new Mock<IParseRomanNumerals>();
            var mockAdder = new Mock<IAddNumbers>();
            mockParser.Setup(p => p.Parse(It.IsAny<string>())).Returns(1);
            mockAdder.Setup(a => a.Add(1, 1)).Verifiable();
            var rnc = new RomanNumeralCalculator(mockParser.Object, mockAdder.Object);
            rnc.Add("", "");
            mockParser.Verify();
        }

    }

    public class FakeAdder : IAddNumbers {
        public int Add(int v1, int v2) {
            return 3;
        }
    }
}
