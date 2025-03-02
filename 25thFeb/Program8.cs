using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

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
            List<string[]> validRecords = new List<string[]>();
            List<string[]> invalidRecords = new List<string[]>();
            
            using (StreamReader reader = new StreamReader(filePath))
            {
                string headerLine = reader.ReadLine(); // Read the header
                Console.WriteLine("Validating records...");
                
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] values = line.Split(',');
                    
                    string email = values[4];
                    string phone = values[5];
                    
                    if (IsValidEmail(email) && IsValidPhone(phone))
                    {
                        validRecords.Add(values);
                    }
                    else
                    {
                        invalidRecords.Add(values);
                    }
                }
            }
            
            if (invalidRecords.Count > 0)
            {
                Console.WriteLine("Invalid Records:");
                Console.WriteLine("--------------------------------");
                foreach (var record in invalidRecords)
                {
                    Console.WriteLine(string.Join(", ", record) + " - ERROR: Invalid Email or Phone Number");
                }
            }
            else
            {
                Console.WriteLine("All records are valid.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error reading the file: " + ex.Message);
        }
    }
    
    static bool IsValidEmail(string email)
    {
        return Regex.IsMatch(email, @"^[^\s@]+@[^\s@]+\.[^\s@]+$");
    }
    
    static bool IsValidPhone(string phone)
    {
        return Regex.IsMatch(phone, @"^\d{10}$");
    }
}
