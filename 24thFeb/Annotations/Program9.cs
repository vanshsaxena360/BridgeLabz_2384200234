using System;
using System.Reflection;

// Step 1: Define the MaxLength attribute for fields.
[AttributeUsage(AttributeTargets.Field, Inherited = false)]
public class MaxLengthAttribute : Attribute
{
    public int Value { get; }
    public MaxLengthAttribute(int value)
    {
        Value = value;
    }
}

// Step 2: Create a User class with a Username field decorated with MaxLength.
public class User
{
    [MaxLength(10)]
    public string Username;

    public User(string username)
    {
        // Validate the field's length using reflection.
        // Get the field info for 'Username'
        FieldInfo field = typeof(User).GetField("Username");
        if (field != null)
        {
            // Retrieve the MaxLength attribute applied on the field.
            var maxLengthAttr = field.GetCustomAttribute<MaxLengthAttribute>();
            if (maxLengthAttr != null && username.Length > maxLengthAttr.Value)
            {
                throw new ArgumentException($"Username cannot exceed {maxLengthAttr.Value} characters.");
            }
        }

        // Set the field if validation passed.
        Username = username;
    }
}

// Step 3: Demonstrate usage
public class Program
{
    public static void Main()
    {
        try
        {
            // This should succeed.
            User user1 = new User("ShortName");
            Console.WriteLine($"User1 created with Username: {user1.Username}");

            // This should fail since the username exceeds the max length of 10.
            User user2 = new User("VeryLongUsername");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
using System;
using System.Reflection;

// Step 1: Define the MaxLength attribute for fields.
[AttributeUsage(AttributeTargets.Field, Inherited = false)]
public class MaxLengthAttribute : Attribute
{
    public int Value { get; }
    public MaxLengthAttribute(int value)
    {
        Value = value;
    }
}

// Step 2: Create a User class with a Username field decorated with MaxLength.
public class User
{
    [MaxLength(10)]
    public string Username;

    public User(string username)
    {
        // Validate the field's length using reflection.
        // Get the field info for 'Username'
        FieldInfo field = typeof(User).GetField("Username");
        if (field != null)
        {
            // Retrieve the MaxLength attribute applied on the field.
            var maxLengthAttr = field.GetCustomAttribute<MaxLengthAttribute>();
            if (maxLengthAttr != null && username.Length > maxLengthAttr.Value)
            {
                throw new ArgumentException($"Username cannot exceed {maxLengthAttr.Value} characters.");
            }
        }

        // Set the field if validation passed.
        Username = username;
    }
}

// Step 3: Demonstrate usage
public class Program
{
    public static void Main()
    {
        try
        {
            // This should succeed.
            User user1 = new User("ShortName");
            Console.WriteLine($"User1 created with Username: {user1.Username}");

            // This should fail since the username exceeds the max length of 10.
            User user2 = new User("VeryLongUsername");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
