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
        // subtract two given numbers with up to a max precision of 5
        public static double subtract(double num1, double num2)
        {
            return Math.Round((num1 - num2), 5);
        }
        // multiply two given numbers with up to a max precision of 5
        public static double product(double num1, double num2)
        {
            return Math.Round((num1 * num2), 5);
        }
        // divide two given numbers with up to a max precision of 5
        public static double divide(double num1, double num2)
        {
            if (num2==0)
            {
                return -99999;
            }
            return Math.Round((num1 / num2), 5);
        }
        // return modulus two given numbers with up to a max precision of 5
        public static double modulus(double num1, double num2)
        {
            if (num2 == 0)
            {
                return -99999;
            }
            return Math.Round((num1 % num2), 5);
        }
        // method that evaluates a string mathematical expresion
        public static double evaluateExpresion(string mathExpresion)
        {

            // separate expresion

            return 0.0;
        }

    }
}
