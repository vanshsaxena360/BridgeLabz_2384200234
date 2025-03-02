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
