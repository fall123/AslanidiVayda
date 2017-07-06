using NUnit.Framework;
using ProjectYP.OneArgument;

namespace ProjectYP.Tests.OneArgument
{
    [TestFixture]
    public class ExpTests
    {
        [TestCase(2, 7.3891)]
        [TestCase(3, 20.0855)]
        [TestCase(5, 148.4132)]
        public void CalculateTest(double first, double expected)
        {
            IOneArgumentCalculator calculator = new Exp();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result, 0.0001);
        }
    }
}