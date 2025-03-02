using System;
using NUnit.Framework;

public class TemperatureConverter
{
    public double CelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    public double FahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }
}

[TestFixture]
public class TemperatureConverterTests
{
    private TemperatureConverter converter;

    [SetUp]
    public void Setup()
    {
        converter = new TemperatureConverter();
    }

    [Test]
    public void CelsiusToFahrenheit_ValidInput_ReturnsCorrectResult()
    {
        Assert.AreEqual(32, converter.CelsiusToFahrenheit(0));
        Assert.AreEqual(212, converter.CelsiusToFahrenheit(100));
    }

    [Test]
    public void FahrenheitToCelsius_ValidInput_ReturnsCorrectResult()
    {
        Assert.AreEqual(0, converter.FahrenheitToCelsius(32));
        Assert.AreEqual(100, converter.FahrenheitToCelsius(212));
    }
}
