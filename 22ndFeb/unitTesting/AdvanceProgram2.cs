using System;
using System.Text.RegularExpressions;
using NUnit.Framework;

public class PasswordValidator
{
    public bool IsValidPassword(string password)
    {
        if (string.IsNullOrWhiteSpace(password)) return false;
        if (password.Length < 8) return false;
        if (!Regex.IsMatch(password, "[A-Z]")) return false;
        if (!Regex.IsMatch(password, "\\d")) return false;
        return true;
    }
}

[TestFixture]
public class PasswordValidatorTests
{
    private PasswordValidator validator;

    [SetUp]
    public void Setup()
    {
        validator = new PasswordValidator();
    }

    [Test]
    public void ValidPassword_ShouldReturnTrue()
    {
        Assert.IsTrue(validator.IsValidPassword("Secure123"));
    }

    [Test]
    public void ShortPassword_ShouldReturnFalse()
    {
        Assert.IsFalse(validator.IsValidPassword("S3c"));
    }

    [Test]
    public void NoUppercase_ShouldReturnFalse()
    {
        Assert.IsFalse(validator.IsValidPassword("secure123"));
    }

    [Test]
    public void NoDigit_ShouldReturnFalse()
    {
        Assert.IsFalse(validator.IsValidPassword("SecurePass"));
    }

    [Test]
    public void EmptyOrNull_ShouldReturnFalse()
    {
        Assert.IsFalse(validator.IsValidPassword(""));
        Assert.IsFalse(validator.IsValidPassword(null));
    }
}
