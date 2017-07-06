using System;

namespace ProjectYP.OneArgument
{
    public class Arcsin : IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Asin(firstArgument);
        }
    }
}