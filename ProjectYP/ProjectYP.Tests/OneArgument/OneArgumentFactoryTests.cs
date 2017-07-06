using System;
using NUnit.Framework;
using ProjectYP.OneArgument;
using ProjectYP.TwoArguments;

namespace ProjectYP.Tests.OneArgument
{
    public class OneArgumentFactoryTests
    {

                [TestCase("bt_sin", typeof(Sin))]
                [TestCase("bt_cos", typeof(Cos))]
                [TestCase("bt_tn", typeof(Tan))]
                [TestCase("bt_ctan", typeof(Ctan))]
                [TestCase("bt_asin", typeof(Arcsin))]
                [TestCase("bt_acos", typeof(Arccos))]
                [TestCase("bt_atan", typeof(Arctan))]
                [TestCase("bt_actan", typeof(Arcctan))]
                [TestCase("bt_exp", typeof(Exp))]
                [TestCase("bt_log", typeof(Ln))]
        public void CreateCalculatorTest(string name, Type type)
            {
                var calculator = OneArgumentFactory.CreateCalculator(name);

                Assert.IsInstanceOf(type, calculator);
            }

        [Test]
        public void WrongCalculatorNameTest()
        {
            Assert.Throws<Exception>(() => OneArgumentFactory.CreateCalculator("BlaBlaCar"));
        }
    }
}