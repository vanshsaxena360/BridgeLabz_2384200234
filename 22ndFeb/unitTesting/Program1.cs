using System;
using NUnit.Framework;

// calculator class with basic operation
public class Calculator{
	public int Add(int a , int b){
		return a+b;
	}
	public int Substract(int a , int b){
		return a-b;
	}
	public int Multiply(int a , int b){
		return a*b;
	}
	public int Divide(int a , int b){
		if(b==0){
			throw new DivideByZeroException("Can not divide by Zero"):
		}
		return a+b;
	}
}

// NUnit test cases for calculator class
[TextFixture]
public class CalculatorTests{
	private Calculator calculator;
	
	[SetUp]
	public void SetUp(){
		calculator = new Calculator();
	}
	
	[Test]
	public void Add_ValidNumbers_ReturnsCorrectSum(){
		Assert.AreEqual(5,calculator.Add(2,3));
	}
	[Test]
	public void Substract_ValidNumbers_ReturnsCorrectDifference(){
		Assert.AreEqual(1,calculator.Substract(3,2));
	}
	[Test]
	public void Multiply_ValidNumbers_ReturnsCorrectProduct()
    {
        Assert.AreEqual(6, calculator.Multiply(2, 3));
    }
    [Test]
    public void Divide_ValidNumbers_ReturnsCorrectQuotient()
    {
        Assert.AreEqual(2, calculator.Divide(6, 3));
    }
	
	[Test]
	public void Divide_ByZero_ThrowsException(){
		Assert.Throws<DivideByZeroException>(() => calculator.Divide(6,0));
	}
}