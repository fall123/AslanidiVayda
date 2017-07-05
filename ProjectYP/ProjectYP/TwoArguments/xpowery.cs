using System;

namespace ProjectYP.TwoArguments
{
    public class xpowery : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Pow( firstArgument , secondArgument);
        }
    }
}
