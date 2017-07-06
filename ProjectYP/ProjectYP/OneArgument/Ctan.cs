using System;

namespace ProjectYP.OneArgument
{
    public class Ctan : IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return 1 / Math.Tan(firstArgument);
        }
    }
}