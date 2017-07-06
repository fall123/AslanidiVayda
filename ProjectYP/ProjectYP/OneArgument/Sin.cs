using System;

namespace ProjectYP.OneArgument
{
    /// <summary>
    /// Calculator for sin
    /// </summary>
    public class Sin:IOneArgumentCalculator
    {
        /// <summary>
        /// Method for calculating.
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <returns> Returns sin for rad </returns>
        public double Calculate(double firstArgument)
        {
            return Math.Sin(firstArgument);
        }
    }
}
