using System;
using NUnit.Framework;

// Bank Account class to handle deposits, withdrawals, and balance checks
public class BankAccount
{
    private double balance;

    // Constructor to set initial balance (must be non-negative)
    public BankAccount(double initialBalance = 0)
    {
        if (initialBalance < 0)
            throw new ArgumentException("Initial balance cannot be negative.");
        
        balance = initialBalance;
    }

    // Method to deposit money
    public void Deposit(double amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Deposit amount must be positive!");
        
        balance += amount;
        Console.WriteLine($"Successfully deposited {amount}. New balance: {balance}");
    }

    // Method to withdraw money
    public void Withdraw(double amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Withdrawal amount must be positive!");
        
        if (amount > balance)
            throw new InvalidOperationException("Insufficient funds! Cannot withdraw more than available balance.");
        
        balance -= amount;
        Console.WriteLine($"Successfully withdrew {amount}. Remaining balance: {balance}");
    }

    // Method to check current balance
    public double GetBalance() => balance;
}

[TestFixture]
public class BankAccountTests
{
    private BankAccount account;

    [SetUp]
    public void Setup()
    {
        // Start with a balance of 100 for each test
        account = new BankAccount(100);
    }

    [Test]
    public void Deposit_ShouldIncreaseBalance_WhenAmountIsValid()
    {
        account.Deposit(50);
        Assert.AreEqual(150, account.GetBalance(), "Balance should increase after deposit.");
    }

    [Test]
    public void Withdraw_ShouldDecreaseBalance_WhenAmountIsValid()
    {
        account.Withdraw(40);
        Assert.AreEqual(60, account.GetBalance(), "Balance should decrease after withdrawal.");
    }

    [Test]
    public void Withdraw_ShouldThrowException_WhenFundsAreInsufficient()
    {
        var ex = Assert.Throws<InvalidOperationException>(() => account.Withdraw(200));
        Assert.AreEqual("Insufficient funds! Cannot withdraw more than available balance.", ex.Message);
    }

    [Test]
    public void Deposit_ShouldThrowException_WhenAmountIsNegative()
    {
        var ex = Assert.Throws<ArgumentException>(() => account.Deposit(-10));
        Assert.AreEqual("Deposit amount must be positive!", ex.Message);
    }

    [Test]
    public void Withdraw_ShouldThrowException_WhenAmountIsNegative()
    {
        var ex = Assert.Throws<ArgumentException>(() => account.Withdraw(-10));
        Assert.AreEqual("Withdrawal amount must be positive!", ex.Message);
    }

    [Test]
    public void CreatingBankAccount_WithNegativeInitialBalance_ShouldThrowException()
    {
        var ex = Assert.Throws<ArgumentException>(() => new BankAccount(-50));
        Assert.AreEqual("Initial balance cannot be negative.", ex.Message);
    }
}