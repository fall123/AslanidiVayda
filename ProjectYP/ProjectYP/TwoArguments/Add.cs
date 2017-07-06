﻿namespace ProjectYP.TwoArguments
{
    /// <summary>
    /// Calculator for addiition.
    /// </summary>
    public class Add : ITwoArgumentsCalculator
    {
        /// <summary>
        /// Method for calculating.
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// <returns> Returns a+b </returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument + secondArgument;
        }
    }
}
