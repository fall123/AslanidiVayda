using System;

namespace ProjectYP.OneArgument
{
    public class Cos : IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Cos(firstArgument);
        }
    }
}