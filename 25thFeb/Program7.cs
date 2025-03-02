using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

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
            List<string[]> records = new List<string[]>();
            using (StreamReader reader = new StreamReader(filePath))
            {
                string headerLine = reader.ReadLine(); // Read the header
                Console.WriteLine("Top 5 Highest Paid Employees:");
                Console.WriteLine("--------------------------------");
                
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] values = line.Split(',');
                    records.Add(values);
                }
            }
            
            var sortedRecords = records.OrderByDescending(r => decimal.Parse(r[3])).Take(5);
            
            foreach (var record in sortedRecords)
            {
                Console.WriteLine($"ID: {record[0]}, Name: {record[1]}, Department: {record[2]}, Salary: {record[3]}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error reading the file: " + ex.Message);
        }
    }
}
