using System;
using CalculatorLib;

namespace DebuggingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            var  x = StaticCalculator.add(-0.002349, 1283.12309083204);
            Console.WriteLine(x);
        }
    }
}
