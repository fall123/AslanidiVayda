using NUnit.Framework;
using ProjectYP.OneArgument;

namespace ProjectYP.Tests.OneArgument
{
    [TestFixture]
    public class ArctanTests
    {
        [TestCase(1, 0.7854)]
        [TestCase(30, 1.5375)]
        [TestCase(45, 1.5486)]
        [TestCase(90, 1.5597)]
        public void CalculateTest(double first, double expected)
        {
            IOneArgumentCalculator calculator = new Arctan();
            double result = calculator.Calculate(first);
            Assert.AreEqual(expected, result, 0.0001);
        }
    }
}