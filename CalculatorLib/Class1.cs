using System;
using System.Collections.Generic;

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
            if (num2 == 0) { throw new DivideByZeroException(); }

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
        public static double evaluateMathString(string mathExpression)
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

            // edge case: starts with negative number
            mathExpression = formatExpression(mathExpression, endOfExpresion);

            // go through the expression O(n)
            for (int i = 0; i < mathExpression.Length; i++)
            {

                currentChar = mathExpression[i];

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
                            result = StaticCalculator.product(stackToAdd.Pop(), num);
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



        // method that takes in a expresion with a leading '-'
        // and returns and equivalent expresion in the format that the evaluate function can operate
        // e.g -2+3/34 = 2+3/34-2-2
        public static string formatExpression(string expression, char endOfExpression)
        {

            // handle expression with leading '-'
            // by appending a expression to the original to maintain equality
            if(expression[0]=='-')
            {
                // removes leading '-'
                expression = expression.Remove(0, 1);

                string expressionToMaintainEquality = "";

                foreach (char character in expression)
                {
                    // when you see + or - stop and add to the end
                    if (character == '+' || character == '-') { break; }

                    // build expresion to append at the end
                    expressionToMaintainEquality += character;
                }
                // maintain inequality
                expression += $"-{2}*{expressionToMaintainEquality}";
            }
            
            return expression+endOfExpression;
        }
    }
}
