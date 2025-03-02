using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "employees.csv"; // Path to the CSV file
        
        try
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("ID,Name,Department,Salary"); // Writing header
                writer.WriteLine("1,Rahul1,IT,60000");
                writer.WriteLine("2,Rahul2,HR,55000");
                writer.WriteLine("3,Rahul3,Finance,70000");
                writer.WriteLine("4,Rahul4,Marketing,50000");
                writer.WriteLine("5,Rahul5,Operations,65000");
            }
            
            Console.WriteLine("Employee details written to file successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error writing to the file: " + ex.Message);
        }
    }
}
