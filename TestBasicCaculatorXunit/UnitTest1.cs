using BasicCaculator;
using BasicCaculator.Utility;
using System.Globalization;

namespace TestBasicCaculatorXunit
{
    public class UnitTest1
    {
        Form1Logic form1Logic = new Form1Logic();

        [Theory]
        [InlineData("4", "3", 7)]
        [InlineData("20.3", "3.7", 24)]
        [InlineData("9999999999999999.99", "0000000000000000.01", 10000000000000000)]
        [InlineData("-309", "-101", -410)]
        [InlineData("9", "-9", 0)]
        public void ShouldAddTwoNumbers(string x, string y, decimal expected)
        {
            var tempX = decimal.Parse(x, CultureInfo.InvariantCulture);

            var tempY = decimal.Parse(y, CultureInfo.InvariantCulture);

            //Act
            string actual = form1Logic.CalculateMethod(ContanstVariable.OPERATIONS.PLUS, tempX, tempY);

            actual = String.IsNullOrWhiteSpace(actual) ? "0" : actual;

            // リターンデータが数字に変換する。
            decimal returnValue = decimal.Parse(actual);

            //Assert
            Assert.Equal(expected, returnValue);
        }

        [Theory]
        [InlineData("4", "3", 1)]
        [InlineData("20.3", "3.7", 16.6)]
        [InlineData("9999999999999999.99", "9999999999999999.99", 0)]
        [InlineData("-309", "-101", -208)]
        [InlineData("-9", "-9", 0)]
        public void ShouldSubtractTwoNumbers(string x, string y, decimal expected)
        {

            var tempX = decimal.Parse(x, CultureInfo.InvariantCulture);

            var tempY = decimal.Parse(y, CultureInfo.InvariantCulture);

            //Act
            string actual = form1Logic.CalculateMethod(ContanstVariable.OPERATIONS.MINUS, tempX, tempY);

            actual = String.IsNullOrWhiteSpace(actual) ? "0" : actual;

            // リターンデータが数字に変換する。
            decimal returnValue = decimal.Parse(actual);

            //Assert
            Assert.Equal(expected, returnValue);
        }
        [Theory]
        [InlineData(4, 3, 12)]
        [InlineData(20.3, 3.7, 75.11)]
        [InlineData(-309, -101, 31209)]
        [InlineData(9, -9, -81)]
        [InlineData(0, 3, 0)]
        public void ShouldMultiplyTwoNumbers(decimal x, decimal y, decimal expected)
        {
            //Act
            string actual = form1Logic.CalculateMethod(ContanstVariable.OPERATIONS.TIMES, x, y);

            actual = String.IsNullOrWhiteSpace(actual) ? "0" : actual;

            // リターンデータが数字に変換する。
            decimal returnValue = decimal.Parse(actual);

            //Assert
            Assert.Equal(expected, returnValue);
        }

        [Theory]
        [InlineData(4, 4, 1)]
        [InlineData(20.3, 0, 0)]
        [InlineData(-300, -100, 3)]
        [InlineData(9, -9, -1)]
        [InlineData(0, 3, 0)]
        public void ShouldDivideTwoNumbers(decimal x, decimal y, decimal expected)
        {
            //Act
            string actual = form1Logic.CalculateMethod(ContanstVariable.OPERATIONS.DIVIDE, x, y);

            actual = String.IsNullOrWhiteSpace(actual) ? "0" : actual;

            // リターンデータが数字に変換する。
            decimal returnValue = decimal.Parse(actual);

            //Assert
            Assert.Equal(expected, returnValue);
        }
    }
}