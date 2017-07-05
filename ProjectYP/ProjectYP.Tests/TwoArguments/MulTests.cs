using NUnit.Framework;
using ProjectYP.TwoArguments;

namespace ProjectYP.Tests.TwoArguments
{
    [TestFixture]
    public class MulTests
    {
        [TestCase(2,4 ,8 )]
        [TestCase(-20, -5, 100)]
        [TestCase(6.5, 7.9, 51.35)]
        [TestCase(13, 3.5, 45.5)]
        public void CalculateTest(double first, double second, double expected)
        {
            ITwoArgumentsCalculator calculator = new Mul();
            double result = calculator.Calculate(first, second);
            Assert.AreEqual(expected, result, 0.0001);
        }
    }
}