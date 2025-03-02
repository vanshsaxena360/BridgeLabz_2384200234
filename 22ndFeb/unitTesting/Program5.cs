using System;
using NUnit.Framework;

// DatabaseConnection class to simulate database operations
public class DatabaseConnection
{
    public bool IsConnected { get; private set; } = false;

    // Simulate database connection
    public void Connect()
    {
        IsConnected = true;
        Console.WriteLine("Database Connected");
    }

    // Simulate disconnecting from database
    public void Disconnect()
    {
        IsConnected = false;
        Console.WriteLine("Database Disconnected");
    }
}

// NUnit Test Cases for DatabaseConnection class
[TestFixture]
public class DatabaseConnectionTests
{
    private DatabaseConnection dbConnection;

    [SetUp]
    public void Setup()
    {
        dbConnection = new DatabaseConnection();
        dbConnection.Connect(); // Establish connection before each test
    }

    [TearDown]
    public void Teardown()
    {
        dbConnection.Disconnect(); // Close connection after each test
    }

    [Test]
    public void Connect_ConnectionIsEstablished()
    {
        Assert.IsTrue(dbConnection.IsConnected, "Database should be connected.");
    }

    [Test]
    public void Disconnect_ConnectionIsClosed()
    {
        dbConnection.Disconnect();
        Assert.IsFalse(dbConnection.IsConnected, "Database should be disconnected.");
    }
}
