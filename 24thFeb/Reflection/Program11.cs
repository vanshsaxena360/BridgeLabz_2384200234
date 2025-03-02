using System;
using System.Reflection;

// Step 1: Define the [Inject] attribute.
[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
public class InjectAttribute : Attribute { }

// Step 2: Create some sample services.
public interface ILogger
{
    void Log(string message);
}

public class ConsoleLogger : ILogger
{
    public void Log(string message) => Console.WriteLine($"[Log]: {message}");
}

public interface IDataService
{
    void GetData();
}

public class DataService : IDataService
{
    public void GetData() => Console.WriteLine("Fetching data...");
}

// Step 3: Create a consumer class with dependencies marked with [Inject].
public class Consumer
{
    // Field injection.
    [Inject]
    private ILogger _logger;

    // Property injection.
    [Inject]
    public IDataService DataService { get; set; }

    public void Execute()
    {
        _logger?.Log("Consumer is executing.");
        DataService?.GetData();
    }
}

// Step 4: Implement a simple DI container.
public static class SimpleContainer
{
    // Register mapping between interface and concrete type (for demo purposes, hardcoded).
    public static object Resolve(Type type)
    {
        // For simplicity, if the type is an interface, we map it to a concrete type.
        if (type == typeof(ILogger))
            return new ConsoleLogger();
        if (type == typeof(IDataService))
            return new DataService();

        // Otherwise, assume type has a parameterless constructor.
        return Activator.CreateInstance(type);
    }

    public static T InjectDependencies<T>() where T : new()
    {
        // Create an instance of T.
        T obj = new T();
        Type type = typeof(T);

        // Inject dependencies into fields.
        foreach (FieldInfo field in type.GetFields(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance))
        {
            if (Attribute.IsDefined(field, typeof(InjectAttribute)))
            {
                object dependency = Resolve(field.FieldType);
                field.SetValue(obj, dependency);
            }
        }

        // Inject dependencies into properties.
        foreach (PropertyInfo prop in type.GetProperties(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance))
        {
            if (Attribute.IsDefined(prop, typeof(InjectAttribute)) && prop.CanWrite)
            {
                object dependency = Resolve(prop.PropertyType);
                prop.SetValue(obj, dependency);
            }
        }

        return obj;
    }
}

// Step 5: Demonstrate dependency injection.
public class Program
{
    public static void Main()
    {
        // Create an instance of Consumer with dependencies injected.
        Consumer consumer = SimpleContainer.InjectDependencies<Consumer>();
        consumer.Execute();
    }
}
