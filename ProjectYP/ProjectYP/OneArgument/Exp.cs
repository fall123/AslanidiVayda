using System;

namespace ProjectYP.OneArgument
{
    class Exp : IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Exp(firstArgument);
        }
    }
}