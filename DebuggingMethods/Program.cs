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
            evaluateMathString("2*6+5.777");
            
        }


        public static double evaluateMathString(string mathExpresion)
        {
            // create stack to hold numbers to add
            Stack<double> stackToAdd = new Stack<double>();

            // initialise variables
            char endOfExpresion = '#';
            char operation = '+';
            double num = 0;
            char currentChar;
            string currentNumberChar = "";
            double result;

            // custom end to detect end of expression
            mathExpresion = $"{mathExpresion}{endOfExpresion}";

            // go through the expression O(n)
            for (int i = 0; i < mathExpresion.Length; i++)
            {

                currentChar = mathExpresion[i];

                // create floating numbers characters
                if (Char.IsDigit(currentChar) || currentChar == '.')
                {
                    currentNumberChar += currentChar;
                }

                // if it is not digit (x / + -) or it is last character in the string (custom '#')
                else if (!Char.IsDigit(currentChar) || currentChar == endOfExpresion)
                {

                    // convert char to double
                    num = Convert.ToDouble(currentNumberChar);

                    // apply operations for x / and change sign for -
                    // add to stack in form Stack = [x1 + x2 + x3 + ...] => e.g[12.0, -23.33, 3*4.1 ... etc]
                    switch (operation)
                    {
                        case '*':
                            result = StaticCalculator.product( stackToAdd.Pop() , num);
                            stackToAdd.Push(result);
                            break;
                        case '/':
                            result = StaticCalculator.divide(stackToAdd.Pop(), num);
                            stackToAdd.Push(result);
                            break;
                        case '-':
                            result = StaticCalculator.product(num, -1);
                            stackToAdd.Push(result);
                            break;
                        case '+':
                            stackToAdd.Push(num);
                            break;
                    }

                    // reset variables
                    num = 0;
                    currentNumberChar = "";
                    operation = currentChar;
                }
            }

            // add all numbers in the stack
            double sum = 0;
            double numToAdd;

            while (stackToAdd.Count > 0)
            {
                numToAdd = stackToAdd.Pop();
                Console.WriteLine($"adding {numToAdd} to {sum}");
                sum = StaticCalculator.add(sum, numToAdd);
            }

            Console.WriteLine($"Final result: {sum}");

            return sum;
        }
    }
}
