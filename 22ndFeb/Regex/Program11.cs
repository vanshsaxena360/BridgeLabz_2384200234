using System;
using System.Text.RegularExpressions;

class Program
{
    static bool IsValidCreditCard(string cardNumber)
    {
        string visaPattern = @"^4\d{15}$";       // Visa: Starts with 4, exactly 16 digits
        string masterPattern = @"^5\d{15}$";     // MasterCard: Starts with 5, exactly 16 digits

        return Regex.IsMatch(cardNumber, visaPattern) || Regex.IsMatch(cardNumber, masterPattern);
    }

    static void Main()
    {
        string[] testCards = { "4111111111111111", "5105105105105100", "1234567812345678", "400012345678" };

        foreach (string card in testCards)
        {
            Console.WriteLine($"{card} is {(IsValidCreditCard(card) ? "Valid" : "Invalid")}");
        }
    }
}
