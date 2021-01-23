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
            double x = Calculate("12+23.212");
            Console.WriteLine(x);
        }

        public static double evaluateExpresion(string mathExpresion)
        {

            string currentNumber = "";
            bool isANumber;
            char currentChar;
            char endOfExpresion = '#';

            Stack<string> stackOfNumbersToAdd = new Stack<string>();

            // custom end
            mathExpresion = $"{mathExpresion}{endOfExpresion}";

            for (int i = 0; i < mathExpresion.Length; i++)
            {
                currentChar = mathExpresion[i];
                isANumber = Char.IsDigit(currentChar);

                // get numbers between operators i.e 12.7
                if (isANumber || currentChar == '.')
                {
                    currentNumber += currentChar;
                }
                // handle operators + - x / and the end of the string if not skips last number
                else if (!isANumber || currentChar == endOfExpresion)
                {
                    Console.WriteLine($"Pushing {currentNumber} into stack");
                    stackOfNumbersToAdd.Push(currentNumber);

                    // handle specific operations


                    // reset number after each operation
                    currentNumber = "";
                }

            }

            return 0.0;
        }


        public static int Calculate(string s)
        {
            s = s.Trim();
            Stack<int> operands = new Stack<int>();
            char operation = '+';
            int num = 0;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    continue;
                }

                if (s[i] >= '0' && s[i] <= '9' || s[i]=='.')
                {
                    num = num * 10 + (s[i] - '0');
                }

                // if it is not digit or it is last character in the string
                if (!(s[i] >= '0' && s[i] <= '9') || i == s.Length - 1)
                {
                    switch (operation)
                    {
                        case '*':
                            operands.Push(operands.Pop() * num);
                            break;
                        case '/':
                            operands.Push(operands.Pop() / num);
                            break;
                        case '-':
                            operands.Push(num * (-1));
                            break;
                        default:
                            operands.Push(num);
                            break;
                    }

                    num = 0;
                }

                if ((s[i] == '+') || (s[i] == '-') || (s[i] == '*') || (s[i] == '/'))
                {
                    operation = s[i];
                }

            }

            int sum = 0;

            while (operands.Count > 0)
            {
                sum += operands.Pop();
            }

            return sum;
        }
    }
}
