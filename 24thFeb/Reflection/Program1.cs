using System;
using System.Reflection;

public class ReflectionInfo
{
    public static void Main()
    {
        Console.Write("Enter the fully qualified class name (e.g., System.String): ");
        string className = Console.ReadLine();

        // Try to get the type from the provided class name.
        Type type = Type.GetType(className);
        if (type == null)
        {
            Console.WriteLine($"Type '{className}' not found.");
            return;
        }

        Console.WriteLine($"\nClass: {type.FullName}");

        // Display Constructors
        Console.WriteLine("\nConstructors:");
        ConstructorInfo[] constructors = type.GetConstructors();
        foreach (var ctor in constructors)
        {
            Console.WriteLine(ctor);
        }

        // Display Methods
        Console.WriteLine("\nMethods:");
        MethodInfo[] methods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly);
        foreach (var method in methods)
        {
            Console.WriteLine(method);
        }

        // Display Fields
        Console.WriteLine("\nFields:");
        FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly);
        foreach (var field in fields)
        {
            Console.WriteLine(field);
        }
    }
}
