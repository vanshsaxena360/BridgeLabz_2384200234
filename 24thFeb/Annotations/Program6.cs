using System;
using System.Reflection;

// Step 1: Define the custom attribute with an optional Level parameter
[AttributeUsage(AttributeTargets.Method)]
public class ImportantMethodAttribute : Attribute
{
    public string Level { get; }

    // Constructor with an optional parameter (default: "HIGH")
    public ImportantMethodAttribute(string level = "HIGH")
    {
        Level = level;
    }
}

// Step 2: Apply the attribute to at least two methods
public class MyApplication
{
    [ImportantMethod] // Uses default level "HIGH"
    public void CriticalOperation()
    {
        Console.WriteLine("Performing critical operation.");
    }

    [ImportantMethod("MEDIUM")]
    public void SecondaryOperation()
    {
        Console.WriteLine("Performing secondary operation.");
    }
}

// Step 3: Retrieve and print annotated methods using Reflection
public class Program
{
    public static void Main()
    {
        Type appType = typeof(MyApplication);
        MethodInfo[] methods = appType.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly);
        
        Console.WriteLine("Important Methods:");
        foreach (MethodInfo method in methods)
        {
            // Check if the method has the ImportantMethod attribute
            var attr = method.GetCustomAttribute<ImportantMethodAttribute>();
            if (attr != null)
            {
                Console.WriteLine($"- {method.Name} (Level: {attr.Level})");
            }
        }
        
        // Optional: Demonstrate method calls
        MyApplication app = new MyApplication();
        app.CriticalOperation();
        app.SecondaryOperation();
    }
}
