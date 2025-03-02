using System;
using System.Diagnostics;
using System.Reflection;

public class TestMethods
{
    public void FastMethod()
    {
        // A quick operation
        for (int i = 0; i < 1000; i++) { }
    }

    public void SlowMethod()
    {
        // Simulate a slower operation
        System.Threading.Thread.Sleep(500);
    }
}

public class Program
{
    public static void Main()
    {
        TestMethods testObj = new TestMethods();
        Type type = typeof(TestMethods);

        // Get all public instance methods declared in TestMethods.
        MethodInfo[] methods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);

        Console.WriteLine("Method Execution Timing:");

        foreach (MethodInfo method in methods)
        {
            // Skip methods with parameters for simplicity.
            if (method.GetParameters().Length > 0)
                continue;

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            // Invoke the method (without parameters).
            method.Invoke(testObj, null);

            stopwatch.Stop();
            Console.WriteLine($"{method.Name} executed in {stopwatch.ElapsedMilliseconds} ms");
        }
    }
}
