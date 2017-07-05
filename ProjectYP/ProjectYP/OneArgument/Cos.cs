using System;

namespace ProjectYP.OneArgument
{
    class Cos : IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Cos(firstArgument);
        }
    }
}