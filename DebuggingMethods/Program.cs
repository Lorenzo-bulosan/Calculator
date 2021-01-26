using System;
using System.Collections.Generic;
using CalculatorLib;

namespace DebuggingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //var  x = StaticCalculator.add(-0.002349, 1283.12309083204);
            //Console.WriteLine(x);

            //double num1 = 3.3 ;
            //double num2 = 9.9;
            //var mod = StaticCalculator.modulus(num1, num2);
            //Console.WriteLine($"should be: {num1%num2} and got {mod}");

            //evaluateExpresion("12+2.2");
            StaticCalculator.evaluateMathString("-2*5/2+2"); // ans = 3
            
        }

    }
}
