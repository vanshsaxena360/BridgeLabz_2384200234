using System;
using System.Diagnostics;
using System.Reflection;

// Step 1: Define the LogExecutionTime attribute.
[AttributeUsage(AttributeTargets.Method)]
public class LogExecutionTimeAttribute : Attribute
{
    // This attribute doesn't require additional members.
}

// Step 2: Create a class with methods decorated with the LogExecutionTime attribute.
public class Worker
{
    [LogExecutionTime]
    public void FastTask()
    {
        // Simulate a fast task.
        for (int i = 0; i < 1000; i++) { }
    }

    [LogExecutionTime]
    public void SlowTask()
    {
        // Simulate a slower task.
        System.Threading.Thread.Sleep(500);
    }
}

// Step 3: Create a helper class that executes a method and logs its execution time if the attribute is applied.
public static class ExecutionLogger
{
    public static void Execute(object instance, string methodName)
    {
        // Get the method information.
        MethodInfo method = instance.GetType().GetMethod(methodName);
        if (method == null)
        {
            Console.WriteLine($"Method {methodName} not found.");
            return;
        }

        // Check if the LogExecutionTime attribute is applied.
        bool shouldLog = method.GetCustomAttribute<LogExecutionTimeAttribute>() != null;
        Stopwatch stopwatch = new Stopwatch();

        if (shouldLog)
        {
            stopwatch.Start();
        }

        // Execute the method.
        method.Invoke(instance, null);

        if (shouldLog)
        {
            stopwatch.Stop();
            Console.WriteLine($"Execution time for {methodName}: {stopwatch.ElapsedMilliseconds} ms");
        }
    }
}

// Step 4: Main Program to execute and compare methods.
public class Program
{
    public static void Main()
    {
        Worker worker = new Worker();

        // Execute methods with logging.
        ExecutionLogger.Execute(worker, "FastTask");
        ExecutionLogger.Execute(worker, "SlowTask");

        // For demonstration, you can call the methods directly as well.
        Console.WriteLine("Direct method calls (without logging helper):");
        worker.FastTask();
        worker.SlowTask();
    }
}
