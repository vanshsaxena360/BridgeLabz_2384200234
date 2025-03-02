using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string filePath = "students.csv"; // Path to the CSV file
        Dictionary<int, string> records = new Dictionary<int, string>();
        HashSet<int> duplicateIds = new HashSet<int>();

        if (!File.Exists(filePath))
        {
            Console.WriteLine("File not found!");
            return;
        }

        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string headerLine = reader.ReadLine(); // Read and skip the header
                
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] values = line.Split(',');
                    int id = int.Parse(values[0]);

                    if (records.ContainsKey(id))
                    {
                        duplicateIds.Add(id);
                    }
                    else
                    {
                        records[id] = line;
                    }
                }
            }

            if (duplicateIds.Count > 0)
            {
                Console.WriteLine("Duplicate Records Found:");
                Console.WriteLine("--------------------------------");
                foreach (int id in duplicateIds)
                {
                    Console.WriteLine(records[id]);
                }
            }
            else
            {
                Console.WriteLine("No duplicate records found.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error reading the file: " + ex.Message);
        }
    }
}
