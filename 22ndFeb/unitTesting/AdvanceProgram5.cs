using System;
using System.Globalization;
using NUnit.Framework;

public class DateFormatter
{
    public string FormatDate(string inputDate)
    {
        if (DateTime.TryParseExact(inputDate, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date))
        {
            return date.ToString("dd-MM-yyyy");
        }
        throw new FormatException("Invalid date format");
    }
}

public class UserRegistration
{
    public void RegisterUser(string username, string email, string password)
    {
        if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
        {
            throw new ArgumentException("Username, email, and password cannot be empty");
        }
        if (!email.Contains("@"))
        {
            throw new ArgumentException("Invalid email format");
        }
        if (password.Length < 8)
        {
            throw new ArgumentException("Password must be at least 8 characters long");
        }
    }
}

[TestFixture]
public class DateFormatterTests
{
    private DateFormatter formatter;

    [SetUp]
    public void Setup()
    {
        formatter = new DateFormatter();
    }

    [Test]
    public void FormatDate_ValidInput_ReturnsFormattedDate()
    {
        Assert.AreEqual("25-12-2023", formatter.FormatDate("2023-12-25"));
    }

    [Test]
    public void FormatDate_InvalidInput_ThrowsFormatException()
    {
        Assert.Throws<FormatException>(() => formatter.FormatDate("12/25/2023"));
    }
}

[TestFixture]
public class UserRegistrationTests
{
    private UserRegistration userRegistration;

    [SetUp]
    public void Setup()
    {
        userRegistration = new UserRegistration();
    }

    [Test]
    public void RegisterUser_ValidInput_DoesNotThrowException()
    {
        Assert.DoesNotThrow(() => userRegistration.RegisterUser("JohnDoe", "john@example.com", "password123"));
    }

    [Test]
    public void RegisterUser_EmptyUsername_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => userRegistration.RegisterUser("", "john@example.com", "password123"));
    }

    [Test]
    public void RegisterUser_InvalidEmail_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => userRegistration.RegisterUser("JohnDoe", "johnexample.com", "password123"));
    }

    [Test]
    public void RegisterUser_ShortPassword_ThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => userRegistration.RegisterUser("JohnDoe", "john@example.com", "pass"));
    }
}
