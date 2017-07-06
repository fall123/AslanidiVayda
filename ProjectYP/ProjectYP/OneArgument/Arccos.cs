using System;

namespace ProjectYP.OneArgument
{
    public class Arccos : IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {

            if (firstArgument > 1 || firstArgument < -1)
            {
                throw new Exception("invalid value for arccos: " + firstArgument);
            }
            return Math.Acos(firstArgument);
        }
    }
}