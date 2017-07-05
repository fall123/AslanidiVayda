namespace ProjectYP.TwoArguments
{
    public class Sub : ITwoArgumentsCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument - secondArgument;
        }
    }
    
}
