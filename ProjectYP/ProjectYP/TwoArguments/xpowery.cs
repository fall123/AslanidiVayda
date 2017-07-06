using System;

namespace ProjectYP.TwoArguments
{
    /// <summary>
    /// Calculator for exponentiation 
    /// </summary>
    public class xpowery : ITwoArgumentsCalculator
    {
        /// <summary>
        /// 
        /// </summary> Method for calculating.
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// <returns>  Returns x^y </returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Pow( firstArgument , secondArgument);
        }
    }
}
