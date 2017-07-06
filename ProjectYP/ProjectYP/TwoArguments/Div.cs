using System;

namespace ProjectYP.TwoArguments
{
   public class Div : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (secondArgument == 0)
            {
                throw new Exception("Division by zero.");
            }
            return firstArgument / secondArgument;
        }
    }
}
