using System;

namespace ProjectYP.OneArgument
{
    public class OneArgumentFactory
    {
        public static IOneArgumentCalculator CreateCalculator(string name)
        {
            switch (name)
            {
                case "bt_sin":
                    return new Sin();

                case "bt_cos":
                    return new Cos();

                case "bt_tn":
                    return new Tan();

                case "bt_ctan":
                    return new Ctan();

                case "bt_exp":
                    return new Exp();

                case "bt_log":
                    return new Ln();

                case "bt_asin":
                    return new Arcsin();

                case "bt_acos":
                    return new Arccos();

                case "bt_atan":
                    return new Arctan();

                case "bt_actan":
                    return new Arcctan();


                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}