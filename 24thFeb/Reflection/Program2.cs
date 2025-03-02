using System;
using System.Reflection;

public class Person
{
    // Private field
    private int age;

    // Constructor to initialize age
    public Person(int age)
    {
        this.age = age;
    }
}

public class Program
{
    public static void Main()
    {
        // Create an instance of Person with an initial age.
        Person person = new Person(25);
        
        // Get the Type object corresponding to Person.
        Type personType = typeof(Person);
        
        // Get the private field 'age' (BindingFlags to access non-public instance fields).
        FieldInfo ageField = personType.GetField("age", BindingFlags.NonPublic | BindingFlags.Instance);
        
        if(ageField != null)
        {
            // Retrieve the current value of the private field.
            int currentAge = (int)ageField.GetValue(person);
            Console.WriteLine("Initial age: " + currentAge);
            
            // Modify the private field's value.
            ageField.SetValue(person, 35);
            
            // Retrieve the new value of the private field.
            int modifiedAge = (int)ageField.GetValue(person);
            Console.WriteLine("Modified age: " + modifiedAge);
        }
        else
        {
            Console.WriteLine("Field 'age' not found.");
        }
    }
}
