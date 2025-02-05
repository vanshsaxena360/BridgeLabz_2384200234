using System;
using System.Collections.Generic;

class Bank
{
    public string Name { get; }

    public Bank(string name)
    {
        Name = name;
    }

    public BankAccount OpenAccount(Customer customer, double initialBalance)
    {
        BankAccount account = new BankAccount(this, customer, initialBalance);
        customer.AddAccount(account);
        return account;
    }
}

class Customer
{
    public string Name { get; }
    private List<BankAccount> accounts = new List<BankAccount>();

    public Customer(string name)
    {
        Name = name;
    }

    public void AddAccount(BankAccount account)
    {
        accounts.Add(account);
    }

    public void ViewBalance()
    {
        Console.WriteLine("Customer: "+Name);
        foreach (var acc in accounts)
        {
            Console.WriteLine("Bank: "+acc.Bank.Name+", Balance: {acc.Balance}");
        }
    }
}

class BankAccount
{
    public Bank Bank { get; }  // Read-only property
    public Customer Customer { get; }  // Read-only property
    public double Balance { get; private set; }

    public BankAccount(Bank bank, Customer customer, double initialBalance)
    {
        Bank = bank;
        Customer = customer;
        Balance = initialBalance;
    }
}

class Program
{
    static void Main()
    {
        Bank bank1 = new Bank("State Bank");
        Customer customer1 = new Customer("Aman");

        // Opening accounts
        bank1.OpenAccount(customer1, 1000);
        bank1.OpenAccount(customer1, 5000);

        // Viewing balance
        customer1.ViewBalance();
    }
}
