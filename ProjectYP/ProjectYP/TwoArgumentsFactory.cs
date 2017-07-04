using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectYP
{
    class TwoArgumentsFactory
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
                    
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}

