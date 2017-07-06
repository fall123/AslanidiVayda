using System;

namespace ProjectYP.OneArgument
{
    public class Ln : IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Log(firstArgument);
        }
    }
}