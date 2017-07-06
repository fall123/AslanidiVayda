using System;

namespace ProjectYP.OneArgument
{
    public class Sin:IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Sin(firstArgument);
        }
    }
}
