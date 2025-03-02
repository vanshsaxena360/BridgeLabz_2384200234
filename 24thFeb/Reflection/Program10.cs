using System;
using System.Reflection;

public interface IGreeting
{
    void SayHello(string name);
}

public class Greeting : IGreeting
{
    public void SayHello(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }
}

// Dynamic proxy implementation using DispatchProxy
public class LoggingProxy<T> : DispatchProxy
{
    public T Target { get; set; }

    protected override object Invoke(MethodInfo targetMethod, object[] args)
    {
        // Log the method name and parameters.
        Console.WriteLine($"[LOG] Calling method: {targetMethod.Name}");
        
        // Invoke the actual method on the target.
        object result = targetMethod.Invoke(Target, args);
        
        return result;
    }
}

public class Program
{
    public static void Main()
    {
        // Create the real object.
        IGreeting realGreeting = new Greeting();
        
        // Create a proxy that intercepts calls to IGreeting.
        IGreeting proxy = CreateProxy<IGreeting, LoggingProxy<IGreeting>>(realGreeting);
        
        // When the proxy's method is invoked, it will log the method call before executing it.
        proxy.SayHello("Alice");
    }
    
    // Helper method to create a proxy.
    public static TInterface CreateProxy<TInterface, TProxy>(TInterface target)
        where TProxy : DispatchProxy, new()
    {
        TInterface proxy = DispatchProxy.Create<TInterface, TProxy>();
        (proxy as LoggingProxy<TInterface>).Target = target;
        return proxy;
    }
}
