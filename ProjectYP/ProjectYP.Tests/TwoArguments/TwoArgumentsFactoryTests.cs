using System;
using NUnit.Framework;
using ProjectYP.TwoArguments;

namespace ProjectYP.Tests.TwoArguments
{
    public class TwoArgumentsFactoryTests
    {
        [TestCase("add", typeof(Add))]
        [TestCase("mul", typeof(Mul))]
        [TestCase("div", typeof(Div))]
        [TestCase("sub", typeof(Sub))]
        [TestCase("logXY", typeof(LogXY))]
        [TestCase("xpowery", typeof(xpowery))]
        public void CreateCalculatorTest(string name, Type type)
        {
            var calculator = TwoArgumentsFactory.CreateCalculator(name);

            Assert.IsInstanceOf(type, calculator);
        }

        [Test]
        public void WrongCalculatorNameTest()
        {
            Assert.Throws<Exception>(() => TwoArgumentsFactory.CreateCalculator("BlaBla"));
        }
    }
}