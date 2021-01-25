using NUnit.Framework;
using System;
using CalculatorLib;

namespace CalculatorTests
{
    public class StaticCalculatorTests
    {
        [SetUp]
        public void Setup(){}

        [TestCase(10, 10, 20.0)]
        [TestCase(-10, 10, 0)]
        [TestCase(-0, -235.54, -235.54)]
        [TestCase(-0.002349, 1283.12309083204, 1283.12074)]
        public void GivenTwoNumbers_ReturnsTheAddition(double num1, double num2, double knownResult)
        {
            var additionResult = StaticCalculator.add(num1, num2);
            Assert.AreEqual(additionResult, knownResult);
        }
        [TestCase(10, 10, 0)]
        [TestCase(-10, -10, 0)]
        [TestCase(10, -10, 20)]
        [TestCase(-0, -235.54, 235.54)]
        [TestCase(0.002349, 1283.12309083204, -1283.12074)]
        public void GivenTwoNumbers_ReturnsTheSubtraction(double num1, double num2, double knownResult)
        {
            var subtractionResult = StaticCalculator.subtract(num1, num2);
            Assert.AreEqual(subtractionResult, knownResult);
        }
        [TestCase(10, 10, 100)]
        [TestCase(-10, -10, 100)]
        [TestCase(10, -10, -100)]
        [TestCase(-0, -235.54, +0)]
        [TestCase(0.00012,9999.1, 1.19989)]
        public void GivenTwoNumbers_ReturnsTheProduct(double num1, double num2, double knownResult)
        {
            var productResult = StaticCalculator.product(num1, num2);
            Assert.AreEqual(productResult, knownResult);
        }
        [TestCase(10, 10, 1)]
        [TestCase(-10, -10, 1)]
        [TestCase(10, -10, -1)]
        [TestCase(-0, -235.54, 0)] 
        public void GivenTwoNumbers_ReturnsTheDivision(double num1, double num2, double knownResult)
        {
            var divisionResult = StaticCalculator.divide(num1, num2);
            Assert.AreEqual(divisionResult, knownResult);
        }
        [TestCase(5.0, 0)]
        public void GivenAParameterToDivideByZero_ReturnsAnException(double num1, double num2)
        {
            var ex = Assert.Throws<DivideByZeroException>(() => StaticCalculator.divide(num1, num2));
        }
        [TestCase(1, 10, 1)]
        [TestCase(1, 0, -99999)]
        [TestCase(1, -4, 1)]
        [TestCase(3.3, 9.9, 3.3)]
        public void GivenTwoNumbers_ReturnsTheModulus(double num1, double num2, double knownResult)
        {
            var modulusResult = StaticCalculator.modulus(num1, num2);
            Assert.AreEqual(modulusResult, knownResult);
        }

        [TestCase("2*6+5.777", 17.777)]
        [TestCase("2*2", 4.0)]
        [TestCase("5/2.5-100", -98.0)]
        public void GivenAString_EvaluateTheMathematicalExpression(string mathExp, double knownResult)
        {
            var evaluateResult = StaticCalculator.evaluateMathString(mathExp);
            Assert.AreEqual(evaluateResult, knownResult);
        }
    }
}