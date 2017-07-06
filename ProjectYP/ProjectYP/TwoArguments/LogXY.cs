using System;

namespace ProjectYP.TwoArguments
{
    /// <summary>
    /// Calculator for LogXY
    /// </summary>
    public class LogXY : ITwoArgumentsCalculator
    {
        /// <summary>
        ///  Method for calculating.
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// <returns> Returns logXY </returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Log(firstArgument, secondArgument);
        }
    }
}