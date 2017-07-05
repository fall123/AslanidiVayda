using NUnit.Framework;
using ProjectYP.TwoArguments;

namespace ProjectYP.Tests.TwoArguments
{
    [TestFixture]
    public class MulTests
    {
        [Test]
        public void CalculateTest()
        {
            ITwoArgumentsCalculator calculator = new Mul();
            double result = calculator.Calculate(7, 5);
            Assert.AreEqual(35, result);
        }
    }
}