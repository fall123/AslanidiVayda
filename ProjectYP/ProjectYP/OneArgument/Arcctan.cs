﻿using System;

namespace ProjectYP.OneArgument
{
    public class Arcctan : IOneArgumentCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Atan(1 / firstArgument);
        }
    }
}