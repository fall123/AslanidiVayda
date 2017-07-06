using NUnit.Framework;
using ProjectYP.OneArgument;

namespace ProjectYP.Tests.OneArgument
{
    [TestFixture]
    public class LnTests
    {
        [TestCase(2, 0.6931)]
        [TestCase(4, 1.3862)]
        [TestCase(7, 1.9459)]
        [TestCase(10, 2.3025)]
        [TestCase(24, 3.1780)]
        [TestCase(35, 3.5553)]
        public void CalculateTest(double first, double expected)
        {
            IOneArgumentCalculator calculator = new Ln();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result, 0.0001);
        }
    }
}