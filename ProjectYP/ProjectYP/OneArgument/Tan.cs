using System;

namespace ProjectYP.OneArgument
{
    class Tan : IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Tan(firstArgument);
        }
    }
}
