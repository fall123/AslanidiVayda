using System;
using NUnit.Framework;
using ProjectYP.TwoArguments;

namespace ProjectYP.Tests.TwoArguments
{
    [TestFixture]
    public class DivTests
    {
        [TestCase(9, 3, 3)]
        [TestCase(-228, 2, -114)]
        [TestCase(777, 7, 111)]
        [TestCase(2.4, 6, 0.4)]
        public void CalculateTest(double first, double second, double expected)
        {
            ITwoArgumentsCalculator calculator = new Div();
            double result = calculator.Calculate(first, second);
            Assert.AreEqual(expected, result, 0.0001);

        }

        [Test]
        public void DivisionByZeroTest()
        {
            ITwoArgumentsCalculator calculator = new Div();
            Assert.Throws<Exception>(() => calculator.Calculate(1, 0));
        }
    }
}