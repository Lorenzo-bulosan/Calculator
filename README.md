# Description

Repository containing the UI, unit test and methods for developing a calculator, you can build this and will produce a .exe windows application that can be run in your computer or any desktop

### :star:Content 

This repository has three solution projects

* Calculator library
* Calculator Test
* Calculator debugger

#### Calculator library

This is a C# .NET Core Class Library project that contains the following methods

> 1. add()
>
> 2. subtract()
> 3. product()
> 4. divide()
> 5. modulus

#### Calculator Test

This is a C# .NET Core Unit Test project that contains the following methods

> 1. GivenTwoNumbers_ReturnsTheAddition()
> 2. GivenTwoNumbers_ReturnsTheSubtraction()
> 3. GivenTwoNumbers_ReturnsTheProduct()
> 4. GivenTwoNumbers_ReturnsTheDivision()
> 5. GivenTwoNumbers_ReturnsTheModulus()

#### Examples

**Unit Test**

```c#
[TestCase(10, 10, 20.0)]
[TestCase(-10, 10, 0)]
[TestCase(-0, -235.54, -235.54)]
[TestCase(-0.002349, 1283.12309083204, 1283.12074)]
public void GivenTwoNumbers_ReturnsTheAddition(double num1, double num2, double knownResult)
{
    var additionResult = StaticCalculator.add(num1, num2);
    Assert.AreEqual(additionResult, knownResult);
}
```

**Implemented Method**

```c#
// add two given numbers with up to a max precision of 5
public static double add(double num1, double num2)
{
    return Math.Round((num1 + num2), 5);          
}
```

