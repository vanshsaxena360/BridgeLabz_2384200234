using System;

public class DateComparison
{
    public static void Main()
    {
        // Request input from the user in "dd/MM/yyyy" format.
        Console.WriteLine("Enter the first date (dd/MM/yyyy): ");
        string input1 = Console.ReadLine();

        // Directly parse the input to DateTime (no TryParse or custom validation)
        DateTime date1 = DateTime.Parse(input1); 

        // Request the second date input from the user
        Console.WriteLine("Enter the second date (dd/MM/yyyy): ");
        string input2 = Console.ReadLine();

        // Directly parse the second date
        DateTime date2 = DateTime.Parse(input2);

        // Compare the two dates
        int result = DateTime.Compare(date1, date2);

        if (result < 0){
            Console.WriteLine("The first date is before the second date.");
        }
        else if (result > 0){
            Console.WriteLine("The first date is after the second date.");
        }
        else{
            Console.WriteLine("The first date is the same as the second date.");
        }
    }
}
