using System;

namespace ProjectYP.OneArgument
{
    class Arccos : IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Acos(firstArgument);
        }
    }
}