using System;
using System.Reflection;

public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    
    public Student()  // Parameterless constructor.
    {
    }
    
    public Student(string name, int age)  // Overloaded constructor.
    {
        Name = name;
        Age = age;
    }
    
    public override string ToString()
    {
        return $"Student Name: {Name}, Age: {Age}";
    }
}

public class Program
{
    public static void Main()
    {
        // Get the Type object for the Student class.
        Type studentType = typeof(Student);
        
        // Create an instance using the parameterless constructor.
        object studentInstance = Activator.CreateInstance(studentType);
        
        // Optionally, you can set properties using reflection.
        PropertyInfo nameProp = studentType.GetProperty("Name");
        PropertyInfo ageProp = studentType.GetProperty("Age");
        
        nameProp.SetValue(studentInstance, "John Doe");
        ageProp.SetValue(studentInstance, 20);
        
        Console.WriteLine(studentInstance);
        
        // Alternatively, create an instance using the parameterized constructor.
        object[] parameters = { "Jane Doe", 22 };
        object studentInstance2 = Activator.CreateInstance(studentType, parameters);
        Console.WriteLine(studentInstance2);
    }
}
