using System;
using System.Collections.Generic;

class BankingSystem
{
    private Dictionary<int, double> accounts = new Dictionary<int, double>(); // Account Number → Balance
    private Queue<Tuple<int, double>> withdrawalQueue = new Queue<Tuple<int, double>>(); // Withdrawal Requests

    public void CreateAccount(int accountNumber, double initialBalance)
    {
        accounts[accountNumber] = initialBalance;
    }

    public void Deposit(int accountNumber, double amount)
    {
        if (accounts.ContainsKey(accountNumber))
        {
            accounts[accountNumber] += amount;
            Console.WriteLine("Deposited Rupee " + amount + " to Account " + accountNumber);
        }
        else
            Console.WriteLine("Account not found.");
    }

    public void RequestWithdrawal(int accountNumber, double amount)
    {
        if (accounts.ContainsKey(accountNumber) && accounts[accountNumber] >= amount)
        {
            withdrawalQueue.Enqueue(Tuple.Create(accountNumber, amount));
            Console.WriteLine("Withdrawal request of Rupee " + amount + " for Account " + accountNumber + " added to queue.");
        }
        else
            Console.WriteLine("Insufficient funds or account not found.");
    }

    public void ProcessWithdrawals()
    {
        Console.WriteLine("\nProcessing Withdrawals:");
        while (withdrawalQueue.Count > 0)
        {
            Tuple<int, double> request = withdrawalQueue.Dequeue();
            int accountNumber = request.Item1;
            double amount = request.Item2;

            if (accounts[accountNumber] >= amount)
            {
                accounts[accountNumber] -= amount;
                Console.WriteLine("Withdrawn Rupee " + amount + " from Account " + accountNumber);
            }
            else
                Console.WriteLine("Insufficient funds for Account " + accountNumber);
        }
    }

    public void DisplaySortedAccounts()
    {
        Console.WriteLine("\nAccounts Sorted by Balance:");
        foreach (KeyValuePair<int, double> acc in SortedAccounts())
            Console.WriteLine("Account " + acc.Key + ": Rupee " + acc.Value);
    }

    private SortedDictionary<int, double> SortedAccounts()
    {
        SortedDictionary<int, double> sorted = new SortedDictionary<int, double>();
        foreach (KeyValuePair<int, double> acc in accounts)
            sorted[acc.Key] = acc.Value;
        return sorted;
    }
}

class Program
{
    static void Main()
    {
        BankingSystem bank = new BankingSystem();

        bank.CreateAccount(101, 5000);
        bank.CreateAccount(102, 3000);
        bank.CreateAccount(103, 7000);
        bank.CreateAccount(104, 2000);

        bank.Deposit(101, 2000);
        bank.Deposit(104, 1000);

        bank.RequestWithdrawal(103, 500);
        bank.RequestWithdrawal(102, 1500);

        bank.ProcessWithdrawals();
        bank.DisplaySortedAccounts();
    }
}
