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
        
        try
        {
            int recordCount = 0;
            using (StreamReader reader = new StreamReader(filePath))
            {
                string headerLine = reader.ReadLine(); // Read the header
                
                while (!reader.EndOfStream)
                {
                    reader.ReadLine();
                    recordCount++;
                }
            }
            
            Console.WriteLine($"Number of records: {recordCount}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error reading the file: " + ex.Message);
        }
    }
}
