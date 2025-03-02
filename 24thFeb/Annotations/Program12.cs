using System;
using System.Collections.Generic;
using System.Reflection;

// Step 1: Define the CacheResult attribute.
[AttributeUsage(AttributeTargets.Method)]
public class CacheResultAttribute : Attribute
{
    // This attribute acts as a marker, so no extra fields are needed.
}

// Step 2: Create a class with a computationally expensive method decorated with CacheResult.
public class ExpensiveCalculations
{
    [CacheResult]
    public int ComputeFactorial(int number)
    {
        // Simulate an expensive operation (e.g., a recursive factorial)
        return number <= 1 ? 1 : number * ComputeFactorial(number - 1);
    }
}

// Step 3: Create a caching helper to intercept method calls and cache results.
public static class CacheHelper
{
    // A simple cache using a nested dictionary:
    // Outer key: method name, Inner key: string representation of arguments, Value: computed result.
    private static readonly Dictionary<string, Dictionary<string, object>> cache = new();

    public static object Invoke(object instance, string methodName, params object[] parameters)
    {
        // Get method info.
        MethodInfo method = instance.GetType().GetMethod(methodName);
        if (method == null)
            throw new Exception($"Method {methodName} not found.");

        // Check if the CacheResult attribute is applied.
        bool isCacheEnabled = method.GetCustomAttribute<CacheResultAttribute>() != null;

        // Create a cache key for the method.
        string methodKey = method.Name;
        // Combine parameters to create a unique key. For simplicity, we use string.Join.
        string paramKey = parameters != null ? string.Join("_", parameters) : string.Empty;

        if (isCacheEnabled)
        {
            // Initialize dictionary for the method if it doesn't exist.
            if (!cache.ContainsKey(methodKey))
                cache[methodKey] = new Dictionary<string, object>();

            // If result exists, return it.
            if (cache[methodKey].ContainsKey(paramKey))
            {
                Console.WriteLine("Returning cached result for: " + methodKey + "(" + paramKey + ")");
                return cache[methodKey][paramKey];
            }
        }

        // Invoke the method if no cached result exists.
        object result = method.Invoke(instance, parameters);

        if (isCacheEnabled)
        {
            // Store the result in cache.
            cache[methodKey][paramKey] = result;
            Console.WriteLine("Storing result in cache for: " + methodKey + "(" + paramKey + ")");
        }

        return result;
    }
}

// Step 4: Demonstrate usage.
public class Program
{
    public static void Main()
    {
        ExpensiveCalculations calc = new ExpensiveCalculations();

        // First call: should compute and store result.
        int number = 5;
        object result1 = CacheHelper.Invoke(calc, "ComputeFactorial", number);
        Console.WriteLine($"Factorial of {number} = {result1}");

        // Second call with same input: should retrieve cached result.
        object result2 = CacheHelper.Invoke(calc, "ComputeFactorial", number);
        Console.WriteLine($"Factorial of {number} = {result2}");

        // For demonstration, call with a different input.
        number = 6;
        object result3 = CacheHelper.Invoke(calc, "ComputeFactorial", number);
        Console.WriteLine($"Factorial of {number} = {result3}");
    }
}
