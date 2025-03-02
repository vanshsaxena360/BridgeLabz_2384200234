using System;
using System.Collections.Generic;
using System.Reflection;

public static class ObjectMapper
{
    // Generic method to create an instance of type T and set its fields from the properties dictionary.
    public static T ToObject<T>(Dictionary<string, object> properties) where T : new()
    {
        // Create an instance of type T.
        T obj = new T();
        Type type = typeof(T);

        // Iterate over each property in the dictionary.
        foreach (var kvp in properties)
        {
            // Try to get the field with the name from the dictionary.
            FieldInfo field = type.GetField(kvp.Key, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            if (field != null && kvp.Value != null)
            {
                // Convert the value to the field's type if needed.
                object convertedValue = Convert.ChangeType(kvp.Value, field.FieldType);
                // Set the field value.
                field.SetValue(obj, convertedValue);
            }
            else
            {
                // Optionally, try setting as a property if no matching field is found.
                PropertyInfo prop = type.GetProperty(kvp.Key, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                if (prop != null && prop.CanWrite && kvp.Value != null)
                {
                    object convertedValue = Convert.ChangeType(kvp.Value, prop.PropertyType);
                    prop.SetValue(obj, convertedValue);
                }
            }
        }
        return obj;
    }
}

// Example class to test object mapping.
public class Person
{
    // Public field.
    public string FirstName;
    
    // Private field.
    private int age;

    // Public property.
    public string LastName { get; set; }

    // For displaying mapped values.
    public override string ToString()
    {
        return $"FirstName: {FirstName}, LastName: {LastName}, Age: {age}";
    }
}

public class Program
{
    public static void Main()
    {
        // Create a dictionary with field and property values.
        var properties = new Dictionary<string, object>
        {
            { "FirstName", "Alice" },
            { "LastName", "Johnson" },
            { "age", 30 }  // Note: even though 'age' is private, we can still set it via reflection.
        };

        // Use the object mapper to create a Person object.
        Person person = ObjectMapper.ToObject<Person>(properties);

        // Display the resulting object.
        Console.WriteLine(person);
    }
}
