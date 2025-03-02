using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public double Marks { get; set; }
}

class Program
{
    static void Main()
    {
        string jsonFilePath = "students.json";
        string csvFilePath = "students.csv";
        string outputJsonFilePath = "converted_students.json";

        // Convert JSON to CSV
        ConvertJsonToCsv(jsonFilePath, csvFilePath);

        // Convert CSV back to JSON
        ConvertCsvToJson(csvFilePath, outputJsonFilePath);
    }

    static void ConvertJsonToCsv(string jsonFilePath, string csvFilePath)
    {
        if (!File.Exists(jsonFilePath))
        {
            Console.WriteLine("JSON file not found!");
            return;
        }

        try
        {
            string jsonData = File.ReadAllText(jsonFilePath);
            List<Student> students = JsonConvert.DeserializeObject<List<Student>>(jsonData);

            using (StreamWriter writer = new StreamWriter(csvFilePath))
            {
                writer.WriteLine("Id,Name,Age,Marks"); // Write header
                foreach (var student in students)
                {
                    writer.WriteLine($"{student.Id},{student.Name},{student.Age},{student.Marks}");
                }
            }

            Console.WriteLine("JSON converted to CSV successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error converting JSON to CSV: " + ex.Message);
        }
    }

    static void ConvertCsvToJson(string csvFilePath, string outputJsonFilePath)
    {
        if (!File.Exists(csvFilePath))
        {
            Console.WriteLine("CSV file not found!");
            return;
        }

        try
        {
            List<Student> students = new List<Student>();
            using (StreamReader reader = new StreamReader(csvFilePath))
            {
                reader.ReadLine(); // Skip header
                while (!reader.EndOfStream)
                {
                    string[] values = reader.ReadLine().Split(',');
                    students.Add(new Student
                    {
                        Id = int.Parse(values[0]),
                        Name = values[1],
                        Age = int.Parse(values[2]),
                        Marks = double.Parse(values[3])
                    });
                }
            }

            string jsonOutput = JsonConvert.SerializeObject(students, Formatting.Indented);
            File.WriteAllText(outputJsonFilePath, jsonOutput);

            Console.WriteLine("CSV converted back to JSON successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error converting CSV to JSON: " + ex.Message);
        }
    }
}