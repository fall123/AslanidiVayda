using System;

namespace ProjectYP.OneArgument
{
    public class Exp : IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Exp(firstArgument);
        }
    }
}