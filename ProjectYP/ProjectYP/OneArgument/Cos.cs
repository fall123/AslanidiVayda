using System;

namespace ProjectYP.OneArgument
{
    /// <summary>
    /// Calculator for cos
    /// </summary>
    public class Cos : IOneArgumentCalculator
    {
        /// <summary>
        /// Method for calculating.
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <returns> Returns cos for rad </returns>
        public double Calculate(double firstArgument)
        {
            return Math.Cos(firstArgument);
        }
    }
}