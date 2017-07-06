using NUnit.Framework;
using ProjectYP.TwoArguments;

namespace ProjectYP.Tests.TwoArguments
{
    [TestFixture]
    public class LogXYTests
    {
        [TestCase(5, 4, 1.161)]
        [TestCase(3, 2, 1.585)]
        [TestCase(6.5, 7.9, 0.9056)]
        [TestCase(13, 3.5, 2.0474)]
        public void CalculateTest(double first, double second, double expected)
        {
            ITwoArgumentsCalculator calculator = new LogXY();
            double result = calculator.Calculate(first, second);
            Assert.AreEqual(expected, result, 0.0001);
        }
    }
}