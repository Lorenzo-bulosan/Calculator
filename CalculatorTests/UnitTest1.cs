using NUnit.Framework;
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

    }
}