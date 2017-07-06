using System;

namespace ProjectYP.TwoArguments
{
    public class TwoArgumentsFactory
    {
        public static ITwoArgumentsCalculator CreateCalculator(string name)
        {
            switch (name)
            {
                case "add":
                    return new Add();
                    
                case "sub":
                    return new Sub();
                    
                case "mul":
                    return new Mul();
                   
                case "div":
                    return new Div();

                case "xpowery":
                    return new xpowery();

                case "logXY":
                    return new LogXY();

                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}

