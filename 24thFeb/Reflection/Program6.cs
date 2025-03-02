using System;
using System.Reflection;

// Step 1: Define the custom attribute Author.
[AttributeUsage(AttributeTargets.Class, Inherited = false)]
public class AuthorAttribute : Attribute
{
    public string Name { get; }
    
    public AuthorAttribute(string name)
    {
        Name = name;
    }
}

// Step 2: Apply the Author attribute to a class.
[Author("John Doe")]
public class SampleClass
{
    public void Display()
    {
        Console.WriteLine("Inside SampleClass.");
    }
}

// Step 3: Retrieve and display the attribute value using Reflection.
public class Program
{
    public static void Main()
    {
        // Get the type information of SampleClass.
        Type sampleType = typeof(SampleClass);
        
        // Retrieve the Author attribute applied to the class.
        AuthorAttribute authorAttr = sampleType.GetCustomAttribute<AuthorAttribute>();
        
        if (authorAttr != null)
        {
            Console.WriteLine($"Author of {sampleType.Name}: {authorAttr.Name}");
        }
        else
        {
            Console.WriteLine("No Author attribute found.");
        }
    }
}
