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
                Console.WriteLine("\nStudents who scored more than 80 marks:");
                Console.WriteLine("--------------------------------");
                
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] values = line.Split(',');
                    
                    if (int.TryParse(values[3], out int marks) && marks > 80)
                    {
                        Console.WriteLine($"ID: {values[0]}, Name: {values[1]}, Age: {values[2]}, Marks: {values[3]}");
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error reading the file: " + ex.Message);
        }
    }
}
