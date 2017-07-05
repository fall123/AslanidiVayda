using System;

namespace ProjectYP.OneArgument
{
    class Sin:IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Sin(firstArgument);
        }
    }
}
