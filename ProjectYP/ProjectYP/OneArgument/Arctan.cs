using System;

namespace ProjectYP.OneArgument
{
    class Arctan : IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Atan(firstArgument);
        }
    }
}