using System;
using NUnit.Framework;

// StringUtils class with utility methods
public class StringUtils
{
    // Method to reverse a string
    public static string Reverse(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    // Method to check if a string is a palindrome
    public static bool IsPalindrome(string str)
    {
        string reversed = Reverse(str);
        return string.Equals(str, reversed, StringComparison.OrdinalIgnoreCase);
    }

    // Method to convert a string to uppercase
    public static string ToUpperCase(string str)
    {
        return str.ToUpper();
    }
}

// NUnit Test Cases for StringUtils class
[TestFixture]
public class StringUtilsTests
{
    [Test]
    public void Reverse_ValidString_ReturnsReversedString()
    {
        Assert.AreEqual("olleh", StringUtils.Reverse("hello"));
    }

    [Test]
    public void IsPalindrome_PalindromeString_ReturnsTrue()
    {
        Assert.IsTrue(StringUtils.IsPalindrome("madam"));
    }

    [Test]
    public void IsPalindrome_NonPalindromeString_ReturnsFalse()
    {
        Assert.IsFalse(StringUtils.IsPalindrome("hello"));
    }

    [Test]
    public void ToUpperCase_LowerCaseString_ReturnsUpperCase()
    {
        Assert.AreEqual("HELLO", StringUtils.ToUpperCase("hello"));
    }
}
