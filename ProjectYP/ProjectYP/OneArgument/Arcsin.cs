using System;

namespace ProjectYP.OneArgument
{
    public class Arcsin : IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            if (firstArgument > 1 || firstArgument < -1)
            {
                throw new Exception("invalid value for arcsin: " + firstArgument);
            }
            return Math.Asin(firstArgument);
        }
    }
}