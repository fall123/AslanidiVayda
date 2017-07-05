using NUnit.Framework;
using ProjectYP.TwoArguments;

namespace ProjectYP.Tests.TwoArguments
{
    [TestFixture]
    public class SubTests
    {
        [TestCase(10, 5, 5)]
        [TestCase(-20, -20, 0)]
        [TestCase(0, 0, 0)]
        [TestCase(6, 100500, -100494)]
        public void CalculateTest(double first, double second, double expected)
        {
            ITwoArgumentsCalculator calculator = new Sub();
            double result = calculator.Calculate(first, second);
            Assert.AreEqual(expected, result, 0.0001);
        }
    }
}