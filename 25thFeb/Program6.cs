using System;
using System.IO;

class Program
{
    static void Main()
    {
        string inputFilePath = "employees.csv"; // Path to the original CSV file
        string outputFilePath = "updated_employees.csv"; // Path to the new CSV file
        
        if (!File.Exists(inputFilePath))
        {
            Console.WriteLine("File not found!");
            return;
        }
        
        try
        {
            using (StreamReader reader = new StreamReader(inputFilePath))
            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                string headerLine = reader.ReadLine();
                writer.WriteLine(headerLine); // Write the header to the new file
                
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] values = line.Split(',');
                    
                    if (values[2].Equals("IT", StringComparison.OrdinalIgnoreCase))
                    {
                        decimal salary = decimal.Parse(values[3]);
                        salary *= 1.10m; // Increase salary by 10%
                        values[3] = salary.ToString("F2");
                    }
                    
                    writer.WriteLine(string.Join(",", values));
                }
            }
            
            Console.WriteLine("Updated employee records saved to 'updated_employees.csv'.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error processing the file: " + ex.Message);
        }
    }
}
