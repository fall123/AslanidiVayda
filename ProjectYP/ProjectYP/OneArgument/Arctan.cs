using System;

namespace ProjectYP.OneArgument
{
    public class Arctan : IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Atan(firstArgument);
        }
    }
}