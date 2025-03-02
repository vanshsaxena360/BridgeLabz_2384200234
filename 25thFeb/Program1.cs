using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "students.csv"; // Path to the CSV file
        
        if (!File.Exists(filePath))
        {
            Console.WriteLine("File not found!");
            return;
        }
        
        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string headerLine = reader.ReadLine(); // Read the header
                Console.WriteLine("\nStudent Details:");
                Console.WriteLine("--------------------------------");
                
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] values = line.Split(',');
                    
                    Console.WriteLine($"ID: {values[0]}, Name: {values[1]}, Age: {values[2]}, Marks: {values[3]}");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error reading the file: " + ex.Message);
        }
    }
}
