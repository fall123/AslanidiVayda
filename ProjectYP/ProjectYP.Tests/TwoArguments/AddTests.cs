using NUnit.Framework;
using ProjectYP.TwoArguments;

namespace ProjectYP.Tests.TwoArguments
{
    [TestFixture]
    public class AddTests
    {
        [TestCase(2, 5, 7)]
        [TestCase(-20, 3.6, -16.4)]
        [TestCase(0, 0, 0)]
        [TestCase(4, 100500, 100504)]
        public void CalculateTest(double first, double second, double expected)
        {
            ITwoArgumentsCalculator calculator = new Add();
            double result = calculator.Calculate(first, second);
            Assert.AreEqual(expected, result, 0.0001);
        }
    }
}