using System;

namespace ProjectYP.OneArgument
{
    public class Arccos : IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Acos(firstArgument);
        }
    }
}