using NUnit.Framework;
using ProjectYP.OneArgument;

namespace ProjectYP.Tests.OneArgument
{
    [TestFixture]
    public class CosTests
    {
        [TestCase(1, 0.5403)]
        [TestCase(30, 0.1542)]
        [TestCase(45, 0.5253)]
        [TestCase(90, -0.4480)]
        public void CalculateTest(double first, double expected)
        {
            IOneArgumentCalculator calculator = new Cos();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result, 0.0001);
        }
    }
}