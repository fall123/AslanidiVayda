using NUnit.Framework;
using ProjectYP.TwoArguments;

namespace ProjectYP.Tests.TwoArguments
{
    [TestFixture]
    public class XpoweryTests
    {
        [TestCase(5,4, 625)]
        [TestCase(3, 2,9)]
        [TestCase(6.5, 7.9, 2642503.1731)]
        [TestCase(13, 3.5, 7921.3962)]
        public void CalculateTest(double first, double second, double expected)
        {
            ITwoArgumentsCalculator calculator = new xpowery();
            double result = calculator.Calculate(first, second);
            Assert.AreEqual(expected, result, 0.0001);
        }
    }
}