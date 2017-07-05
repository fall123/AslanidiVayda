using System;

namespace ProjectYP.TwoArguments
{
    public class LogXY : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Log(firstArgument, secondArgument);
        }
    }
}