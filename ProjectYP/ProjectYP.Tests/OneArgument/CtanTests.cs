using NUnit.Framework;
using ProjectYP.OneArgument;

namespace ProjectYP.Tests.OneArgument
{
    [TestFixture]
    public class CtanTests
    {
        [TestCase(1, 0.6420)]
        [TestCase(30, -0.1561)]
        [TestCase(45, 0.6173)]
        [TestCase(90, -0.5012)]
        public void CalculateTest(double first, double expected)
        {
            IOneArgumentCalculator calculator = new Ctan();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result, 0.0001);
        }
    }
}