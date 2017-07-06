using System;
using NUnit.Framework;
using ProjectYP.OneArgument;

namespace ProjectYP.Tests.OneArgument
{
    [TestFixture]
    public class ArcsinTests
    {
        [TestCase(-1, -1.5708)]
        [TestCase(0, 0)]
        [TestCase(1, 1.5708)]
        public void CalculateTest(double first, double expected)
        {
            IOneArgumentCalculator calculator = new Arcsin();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result, 0.0001);
        }

        [TestCase(-2)]
        [TestCase(2)]
        public void InvalidInputTest(double value)
        {
            IOneArgumentCalculator calculator = new Arcsin();
            Assert.Throws<Exception>(() => calculator.Calculate(value));
        }
    }
}