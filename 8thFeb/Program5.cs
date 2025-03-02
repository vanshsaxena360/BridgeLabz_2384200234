using System;

class BankAccount
{
    // Marking method as virtual so it can be overridden
    public virtual void Withdraw(double amount)
    {
        Console.WriteLine("Withdrawing "+amount+" from the bank account.");
    }
}

class SavingsAccount : BankAccount
{
    // Correctly overriding the method
    public override void Withdraw(double amount)
    {
        Console.WriteLine("Withdrawing "+amount+" from savings account with different rules.");
    }
}

class FixedDepositAccount : SavingsAccount
{
    // Sealing method so it can't be overridden further
    public sealed override void Withdraw(double amount)
    {
        Console.WriteLine("Withdrawals are not allowed from Fixed Deposit Account.");
    }
}

class Program
{
    static void Main()
    {
        BankAccount account1 = new SavingsAccount();
        account1.Withdraw(100);  // Calls SavingsAccount's method

        BankAccount account2 = new FixedDepositAccount();
        account2.Withdraw(200);  // Calls sealed method in FixedDepositAccount
    }
}
