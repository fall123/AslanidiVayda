namespace ProjectYP.TwoArguments
{
    /// <summary>
    /// Calculator for multiplication
    /// </summary>
    public class Mul : ITwoArgumentsCalculator
    {
        /// <summary>
        ///  Method for calculating.
        /// </summary>
        /// <param name="firstArgument"></param>
        /// <param name="secondArgument"></param>
        /// <returns>  Returns a*b </returns>
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument * secondArgument;
        }
    }
}
