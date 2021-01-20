using System;

namespace CalculatorLib
{
    public class StaticCalculator
    {
       
        // add two given numbers with up to a max precision of 5
        public static double add(double num1, double num2)
        {
            return Math.Round((num1 + num2), 5);          
        }

        public static double subtract(double num1, double num2)
        {
            return Math.Round((num1 - num2), 5);
        }

        public static double product(double num1, double num2)
        {
            return Math.Round((num1 * num2), 5);
        }

    }
}
