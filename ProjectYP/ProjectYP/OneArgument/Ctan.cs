using System;

namespace ProjectYP.OneArgument
{
    class Ctan : IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return 1 / Math.Tan(firstArgument);
        }
    }
}