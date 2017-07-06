using NUnit.Framework;
using ProjectYP.OneArgument;

namespace ProjectYP.Tests.OneArgument
{
    [TestFixture]
    public class TanTests
    {
        [TestCase(1, 1.5574)]
        [TestCase(30, -6.4053)]
        [TestCase(45, 1.6197)]
        [TestCase(90, -1.9952)]
        public void CalculateTest(double first, double expected)
        {
            IOneArgumentCalculator calculator = new Tan();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result, 0.0001);
        }
    }
}