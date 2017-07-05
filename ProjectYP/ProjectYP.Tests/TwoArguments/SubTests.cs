using NUnit.Framework;
using ProjectYP.TwoArguments;

namespace ProjectYP.Tests.TwoArguments
{
    [TestFixture]
    public class SubTests
    {
        [Test]
        public void CalculateTest()
        {
            ITwoArgumentsCalculator calculator = new Sub();
            double result = calculator.Calculate(9, 3);
            Assert.AreEqual(6, result);
        }
    }
}