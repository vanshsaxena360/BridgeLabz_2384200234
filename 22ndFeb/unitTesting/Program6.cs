using System;
using NUnit.Framework;

// Utility class with IsEven method
public class NumberUtils
{
    // Method to check if a number is even
    public static bool IsEven(int number)
    {
        return number % 2 == 0;
    }
}

// NUnit Test Cases for NumberUtils class
[TestFixture]
public class NumberUtilsTests
{
    [TestCase(2, ExpectedResult = true)]
    [TestCase(4, ExpectedResult = true)]
    [TestCase(6, ExpectedResult = true)]
    [TestCase(7, ExpectedResult = false)]
    [TestCase(9, ExpectedResult = false)]
    public bool IsEven_WhenCalled_ReturnsCorrectResult(int number)
    {
        return NumberUtils.IsEven(number);
    }
}