using System;

namespace ProjectYP.OneArgument
{
    public class Tan : IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Tan(firstArgument);
        }
    }
}
