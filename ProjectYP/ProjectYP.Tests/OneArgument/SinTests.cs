using NUnit.Framework;
using ProjectYP.OneArgument;

namespace ProjectYP.Tests.OneArgument
{
    [TestFixture]
    public class SinTests
    {
        [TestCase(1, 0.8414)]
        [TestCase(30, -0.9880)]
        [TestCase(45, 0.8509)]
        [TestCase(90, 0.8939)]
        public void CalculateTest(double first, double expected)
        {
            IOneArgumentCalculator calculator = new Sin();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result, 0.0001);
        }
    }
}