using System;
using System.Reflection;

public class Calculator
{
    // Private method to multiply two integers.
    private int Multiply(int a, int b)
    {
        return a * b;
    }
}

public class Program
{
    public static void Main()
    {
        // Create an instance of Calculator.
        Calculator calc = new Calculator();
        
        // Get the Type object for Calculator.
        Type calcType = typeof(Calculator);
        
        // Retrieve the private method 'Multiply' using reflection.
        MethodInfo multiplyMethod = calcType.GetMethod("Multiply", BindingFlags.NonPublic | BindingFlags.Instance);
        
        if (multiplyMethod != null)
        {
            // Define the parameters to pass to the Multiply method.
            object[] parameters = new object[] { 5, 3 };
            
            // Invoke the private method on the Calculator instance.
            object result = multiplyMethod.Invoke(calc, parameters);
            
            Console.WriteLine($"The result of Multiply(5, 3) is: {result}");
        }
        else
        {
            Console.WriteLine("The method 'Multiply' was not found.");
        }
    }
}
