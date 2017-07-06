using NUnit.Framework;
using ProjectYP.OneArgument;

namespace ProjectYP.Tests.OneArgument
{
    [TestFixture]
    public class ArccosTests
    {
        [TestCase(1, 0)]
        [TestCase(0, 1.5708)]
        [TestCase(-1, 3.1416)]
        public void CalculateTest(double first, double expected)
        {
            IOneArgumentCalculator calculator = new Arccos();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result, 0.0001);
        }
    }
}