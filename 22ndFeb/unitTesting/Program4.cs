using System;
using NUnit.Framework;

// MathOperations class with division method
public class MathOperations
{
    // Method to perform division
    public static int Divide(int a, int b)
    {
        if (b == 0)
            throw new ArithmeticException("Cannot divide by zero.");
        return a / b;
    }
}

// NUnit Test Cases for MathOperations class
[TestFixture]
public class MathOperationsTests
{
    [Test]
    public void Divide_ValidNumbers_ReturnsQuotient()
    {
        Assert.AreEqual(2, MathOperations.Divide(10, 5));
    }

    [Test]
    public void Divide_ByZero_ThrowsArithmeticException()
    {
        Assert.Throws<ArithmeticException>(() => MathOperations.Divide(10, 0));
    }
}
