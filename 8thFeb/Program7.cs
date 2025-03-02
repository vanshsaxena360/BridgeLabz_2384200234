using System;

class Person
{
    private string name;  // Private field (cannot be accessed directly)

    public string Name   // Encapsulated with a property
    {
        get { return name; }
        set
        {
            if (!string.IsNullOrEmpty(value))  // Validation check
                name = value;
            else
                Console.WriteLine("Invalid name");
        }
    }
}

class Student : Person
{
    public void Display()
    {
        Console.WriteLine("Student Name: "+Name);  // Accessing via property
    }
}

class Program
{
    static void Main()
    {
        Student student = new Student();
        student.Name = "Aman";  // Controlled access via setter
        student.Display();

        student.Name = "";  // Invalid input, but handled safely
    }
}
