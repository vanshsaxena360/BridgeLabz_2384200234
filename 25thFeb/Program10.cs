using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string file1Path = "students1.csv"; // First CSV file
        string file2Path = "students2.csv"; // Second CSV file
        string outputFilePath = "merged_students.csv"; // Output file

        if (!File.Exists(file1Path) || !File.Exists(file2Path))
        {
            Console.WriteLine("One or both files not found!");
            return;
        }

        try
        {
            Dictionary<int, string[]> studentData1 = new Dictionary<int, string[]>();
            Dictionary<int, string[]> studentData2 = new Dictionary<int, string[]>();
            
            // Read first CSV (ID, Name, Age)
            using (StreamReader reader = new StreamReader(file1Path))
            {
                reader.ReadLine(); // Skip header
                while (!reader.EndOfStream)
                {
                    string[] values = reader.ReadLine().Split(',');
                    int id = int.Parse(values[0]);
                    studentData1[id] = values;
                }
            }

            // Read second CSV (ID, Marks, Grade)
            using (StreamReader reader = new StreamReader(file2Path))
            {
                reader.ReadLine(); // Skip header
                while (!reader.EndOfStream)
                {
                    string[] values = reader.ReadLine().Split(',');
                    int id = int.Parse(values[0]);
                    studentData2[id] = values;
                }
            }

            // Merge data based on ID
            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                writer.WriteLine("ID,Name,Age,Marks,Grade"); // Write header
                
                foreach (var entry in studentData1)
                {
                    int id = entry.Key;
                    string[] values1 = entry.Value;
                    string[] values2 = studentData2.ContainsKey(id) ? studentData2[id] : new string[] { id.ToString(), "", "" };
                    
                    writer.WriteLine($"{id},{values1[1]},{values1[2]},{values2[1]},{values2[2]}");
                }
            }

            Console.WriteLine("Merged student records saved to 'merged_students.csv'.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error processing files: " + ex.Message);
        }
    }
}
