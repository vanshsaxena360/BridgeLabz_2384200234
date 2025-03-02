using System;
using System.Reflection;

// Step 1: Define the RoleAllowed attribute for classes or methods.
[AttributeUsage(AttributeTargets.Method, Inherited = false)]
public class RoleAllowedAttribute : Attribute
{
    public string Role { get; }
    
    public RoleAllowedAttribute(string role)
    {
        Role = role;
    }
}

// Step 2: Simulate a user context.
public static class UserContext
{
    // Change this value to simulate different user roles ("ADMIN", "USER", etc.)
    public static string CurrentUserRole { get; set; } = "USER";
}

// Step 3: Create a class with a method decorated with the RoleAllowed attribute.
public class SecureOperations
{
    [RoleAllowed("ADMIN")]
    public void AdminOnlyOperation()
    {
        Console.WriteLine("Performing an administrative operation.");
    }
    
    // An unprotected method (for demonstration purposes)
    public void PublicOperation()
    {
        Console.WriteLine("Performing a public operation.");
    }
}

// Step 4: Create a helper to validate role-based access before invoking the method.
public static class AccessControlInvoker
{
    public static void Invoke(object instance, string methodName)
    {
        MethodInfo method = instance.GetType().GetMethod(methodName);
        if (method == null)
        {
            Console.WriteLine($"Method {methodName} not found.");
            return;
        }
        
        // Check if the method has a RoleAllowed attribute.
        var roleAttr = method.GetCustomAttribute<RoleAllowedAttribute>();
        if (roleAttr != null)
        {
            // Validate if the current user role matches the allowed role.
            if (!string.Equals(UserContext.CurrentUserRole, roleAttr.Role, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Access Denied!");
                return;
            }
        }
        
        // Invoke the method if access is allowed.
        method.Invoke(instance, null);
    }
}

// Step 5: Demonstrate role-based access control in action.
public class Program
{
    public static void Main()
    {
        SecureOperations operations = new SecureOperations();
        
        Console.WriteLine("User Role: " + UserContext.CurrentUserRole);
        Console.WriteLine("Trying to invoke AdminOnlyOperation:");
        AccessControlInvoker.Invoke(operations, "AdminOnlyOperation");
        
        // Now, let's simulate an admin user.
        UserContext.CurrentUserRole = "ADMIN";
        Console.WriteLine("\nUser Role: " + UserContext.CurrentUserRole);
        Console.WriteLine("Trying to invoke AdminOnlyOperation:");
        AccessControlInvoker.Invoke(operations, "AdminOnlyOperation");
        
        // Unprotected method, always allowed.
        Console.WriteLine("\nInvoking PublicOperation:");
        AccessControlInvoker.Invoke(operations, "PublicOperation");
    }
}
