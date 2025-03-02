using System;
using System.IO;
using System.Collections.Generic;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public double Marks { get; set; }

    public Student(int id, string name, int age, double marks)
    {
        Id = id;
        Name = name;
        Age = age;
        Marks = marks;
    }

    public override string ToString()
    {
        return $"Student {{ ID: {Id}, Name: {Name}, Age: {Age}, Marks: {Marks} }}";
    }
}

class Program
{
    static void Main()
    {
        string filePath = "students.csv"; // Path to the CSV file
        List<Student> students = new List<Student>();

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
                    string name = values[1];
                    int age = int.Parse(values[2]);
                    double marks = double.Parse(values[3]);
                    
                    students.Add(new Student(id, name, age, marks));
                }
            }

            // Print student objects
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error reading the file: " + ex.Message);
        }
    }
}
