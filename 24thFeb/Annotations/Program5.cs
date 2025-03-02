using System;
using System.Reflection;

// Step 1: Define the repeatable attribute
[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public class BugReportAttribute : Attribute
{
    public string Description { get; }
    
    public BugReportAttribute(string description)
    {
        Description = description;
    }
}

// Step 2: Apply the attribute multiple times on a method
public class SoftwareComponent
{
    [BugReport("NullReferenceException in data processing.")]
    [BugReport("Incorrect calculation when input is negative.")]
    public void ProcessData()
    {
        Console.WriteLine("Processing data...");
    }
}

// Step 3: Retrieve and print all BugReport attributes using reflection
public class Program
{
    public static void Main()
    {
        Type componentType = typeof(SoftwareComponent);
        MethodInfo methodInfo = componentType.GetMethod("ProcessData");
        
        // Retrieve all BugReport attributes on the method
        var bugReports = methodInfo.GetCustomAttributes<BugReportAttribute>();
        
        Console.WriteLine("Bug Reports for ProcessData method:");
        foreach (var bug in bugReports)
        {
            Console.WriteLine($"- {bug.Description}");
        }
        
        // For demonstration, call the method as well
        SoftwareComponent component = new SoftwareComponent();
        component.ProcessData();
    }
}
