using System;
using System.Reflection;

// Step 1: Define the Custom Attribute
[AttributeUsage(AttributeTargets.Method, Inherited = false)]
public class TaskInfoAttribute : Attribute
{
    public int Priority { get; }
    public string AssignedTo { get; }

    public TaskInfoAttribute(int priority, string assignedTo)
    {
        Priority = priority;
        AssignedTo = assignedTo;
    }
}

// Step 2: Apply the Attribute to a Method in TaskManager
public class TaskManager
{
    [TaskInfo(1, "Alice")]
    public void PerformTask()
    {
        Console.WriteLine("Task is being performed.");
    }
}

// Step 3: Retrieve the Attribute Details Using Reflection
public class Program
{
    public static void Main()
    {
        Type taskManagerType = typeof(TaskManager);
        MethodInfo methodInfo = taskManagerType.GetMethod("PerformTask");

        var attribute = methodInfo.GetCustomAttribute<TaskInfoAttribute>();

        if (attribute != null)
        {
            Console.WriteLine("Method 'PerformTask' has TaskInfo attribute with Priority = "+attribute.Priority+" and AssignedTo = "+attribute.AssignedTo);
        }
        else
        {
            Console.WriteLine("No TaskInfo attribute found on 'PerformTask'.");
        }

        // For demonstration, also call the method:
        TaskManager tm = new TaskManager();
        tm.PerformTask();
    }
}
