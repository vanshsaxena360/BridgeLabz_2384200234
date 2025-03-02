using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "employees.csv"; // Path to the CSV file
        
        if (!File.Exists(filePath))
        {
            Console.WriteLine("File not found!");
            return;
        }
        
        Console.Write("Enter employee name to search: ");
        string searchName = Console.ReadLine();
        
        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string headerLine = reader.ReadLine(); // Read the header
                bool found = false;
                
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] values = line.Split(',');
                    
                    if (values[1].Equals(searchName, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine($"Department: {values[2]}, Salary: {values[3]}");
                        found = true;
                        break;
                    }
                }
                
                if (!found)
                {
                    Console.WriteLine("Employee not found.");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error reading the file: " + ex.Message);
        }
    }
}
