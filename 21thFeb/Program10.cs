using System;

// Custom exception for insufficient funds
class InsufficientFundsException : Exception
{
    public InsufficientFundsException(string message) : base(message) { }
}

class BankAccount
{
    private double balance;

    public BankAccount(double initialBalance)
    {
        balance = initialBalance;
    }

    // Method to withdraw amount
    public void Withdraw(double amount)
    {
        if (amount < 0)
        {
            throw new ArgumentException("Invalid amount!");
        }
        if (amount > balance)
        {
            throw new InsufficientFundsException("Insufficient balance!");
        }
        balance -= amount;
        Console.WriteLine("Withdrawal successful, new balance: "+balance);
    }
}

class Program
{
    static void Main()
    {
        try
        {
            // Creating a bank account with an initial balance
            Console.Write("Enter initial balance: ");
            double initialBalance = double.Parse(Console.ReadLine());
            BankAccount account = new BankAccount(initialBalance);

            // Taking user input for withdrawal amount
            Console.Write("Enter withdrawal amount: ");
            double amount = double.Parse(Console.ReadLine());
            account.Withdraw(amount);
        }
        catch (InsufficientFundsException ex)
        {
            // Handling insufficient balance exception
            Console.WriteLine(ex.Message);
        }
        catch (ArgumentException ex)
        {
            // Handling invalid amount exception
            Console.WriteLine(ex.Message);
        }
        catch (FormatException)
        {
            // Handling non-numeric input
            Console.WriteLine("Error: Please enter a valid numeric value.");
        }
        catch (Exception ex)
        {
            // Handling unexpected exceptions
            Console.WriteLine("An unexpected error occurred: " + ex.Message);
        }
    }
}
