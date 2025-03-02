using System;
using System.Reflection;

// Step 1: Define the Todo attribute
[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public class TodoAttribute : Attribute
{
    public string Task { get; }
    public string AssignedTo { get; }
    public string Priority { get; }

    // Constructor with required Task and AssignedTo, Priority is optional (default "MEDIUM")
    public TodoAttribute(string task, string assignedTo, string priority = "MEDIUM")
    {
        Task = task;
        AssignedTo = assignedTo;
        Priority = priority;
    }
}

// Step 2: Apply the attribute to multiple methods
public class ProjectFeatures
{
    [Todo("Implement login functionality", "Alice", "HIGH")]
    public void LoginFeature()
    {
        Console.WriteLine("Login feature under development.");
    }

    [Todo("Design user dashboard", "Bob")]
    public void DashboardFeature()
    {
        Console.WriteLine("Dashboard feature under development.");
    }

    [Todo("Add unit tests", "Charlie", "LOW")]
    public void TestingFeature()
    {
        Console.WriteLine("Testing feature under development.");
    }
}

// Step 3: Retrieve and print all pending tasks using Reflection
public class Program
{
    public static void Main()
    {
        Type featureType = typeof(ProjectFeatures);
        MethodInfo[] methods = featureType.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly);
        
        Console.WriteLine("Pending Tasks:");
        foreach (MethodInfo method in methods)
        {
            // Retrieve all Todo attributes applied on the method (if any)
            var todos = method.GetCustomAttributes<TodoAttribute>();
            foreach (var todo in todos)
            {
                Console.WriteLine($"- Method: {method.Name}");
                Console.WriteLine($"  Task: {todo.Task}");
                Console.WriteLine($"  Assigned To: {todo.AssignedTo}");
                Console.WriteLine($"  Priority: {todo.Priority}");
                Console.WriteLine();
            }
        }

        // Optional: Create an instance and call the methods to show they work
        ProjectFeatures features = new ProjectFeatures();
        features.LoginFeature();
        features.DashboardFeature();
        features.TestingFeature();
    }
}
