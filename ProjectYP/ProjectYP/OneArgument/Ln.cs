using System;

namespace ProjectYP.OneArgument
{
    class Ln : IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Log(firstArgument);
        }
    }
}