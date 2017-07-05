﻿using NUnit.Framework;
using ProjectYP.TwoArguments;

namespace ProjectYP.Tests.TwoArguments
{
    [TestFixture]
    public class AddTests
    {
        [Test]
        public void CalculateTest()
        {
            ITwoArgumentsCalculator calculator=new Add();
            double result = calculator.Calculate(2,5);
            Assert.AreEqual(7, result);
        }
    }
}