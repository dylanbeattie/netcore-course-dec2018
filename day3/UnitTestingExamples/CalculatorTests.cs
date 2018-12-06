using Xunit;
using Shouldly;

namespace UnitTestingExamples {

    public class CalculatorTests {
        // [Fact]
        // public void Addition() {
        //     var c = new Calculator();
        //     var result = c.Add(1,2);
        //     result.ShouldBe(3);
        // }

        [Fact]
        public void Subtraction() {
            var c = new Calculator();
            var result = c.Subtract(8,2);
            result.ShouldBe(6);
        }

        [Theory]
        [InlineData(1,2,3)]        
        [InlineData(2,2,4)]
        [InlineData(3,4,7)]
        public void Addition(int x, int y, int z) {
            var c = new Calculator();
            c.Add(x,y).ShouldBe(z);
        }
    }

}