using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectYP
{
    class OneArgumentFactory
    {
        public static IOneArgumentCalculator CreateCalculator(string name)
        {
            switch (name)
            {
                case "bt_sin":
                    return new Sin();

                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}