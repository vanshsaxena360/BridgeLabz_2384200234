using System;
using System.Reflection;

public class MathOperations
{
    public int Add(int a, int b)
    {
        return a + b;
    }
    
    public int Subtract(int a, int b)
    {
        return a - b;
    }
    
    public int Multiply(int a, int b)
    {
        return a * b;
    }
}

public class Program
{
    public static void Main()
    {
        MathOperations mathOps = new MathOperations();
        
        Console.Write("Enter the method to invoke (Add, Subtract, Multiply): ");
        string methodName = Console.ReadLine();
        
        // Get the method information based on user input.
        MethodInfo method = typeof(MathOperations).GetMethod(methodName, BindingFlags.Public | BindingFlags.Instance);
        
        if (method != null)
        {
            Console.Write("Enter the first number: ");
            int a = int.Parse(Console.ReadLine());
            
            Console.Write("Enter the second number: ");
            int b = int.Parse(Console.ReadLine());
            
            // Invoke the method dynamically with the provided parameters.
            object result = method.Invoke(mathOps, new object[] { a, b });
            Console.WriteLine($"Result of {methodName}({a}, {b}) = {result}");
        }
        else
        {
            Console.WriteLine($"Method '{methodName}' not found.");
        }
    }
}
