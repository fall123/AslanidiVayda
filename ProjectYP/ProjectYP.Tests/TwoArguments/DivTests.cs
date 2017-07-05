using NUnit.Framework;
using ProjectYP.TwoArguments;

namespace ProjectYP.Tests.TwoArguments
{
    [TestFixture]
    public class DivTests
    {
        [Test]
        public void CalculateTest()
        {
            ITwoArgumentsCalculator calculator = new Div();
            double result = calculator.Calculate(20, 5);
            Assert.AreEqual(4, result);
        }
    }
}