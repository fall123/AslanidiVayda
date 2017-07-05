using System;

namespace ProjectYP.OneArgument
{
    class Arcsin : IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Asin(firstArgument);
        }
    }
}