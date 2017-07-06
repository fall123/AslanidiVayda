using System;

namespace ProjectYP.TwoArguments
{
    /// <summary>
    /// Calculator for division
    /// </summary>
    public class Div : ITwoArgumentsCalculator
    {
        /// <summary>
        ///  Method for calculating.
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// <returns> Returns a/b </returns>
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
