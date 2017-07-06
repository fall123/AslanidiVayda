using NUnit.Framework;
using ProjectYP.OneArgument;

namespace ProjectYP.Tests.OneArgument
{
    [TestFixture]
    public class ArcctanTests
    {
        [TestCase(0, 1.5708)]
        [TestCase(1, 0.7854)]
        [TestCase(30, 0.0333)]
        [TestCase(45, 0.0222)]
        [TestCase(90, 0.0111)]
        public void CalculateTest(double first, double expected)
        {
            IOneArgumentCalculator calculator = new Arcctan();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result, 0.0001);
        }
    }
}