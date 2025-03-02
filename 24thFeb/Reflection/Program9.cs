using System;
using System.Reflection;
using System.Text;

public static class JsonConverter
{
    public static string ToJson(object obj)
    {
        if (obj == null)
            return "null";

        Type type = obj.GetType();
        StringBuilder json = new StringBuilder();
        json.Append("{");

        // Retrieve all public and non-public instance fields.
        FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

        for (int i = 0; i < fields.Length; i++)
        {
            FieldInfo field = fields[i];
            // Get the field name and value.
            string fieldName = field.Name;
            object value = field.GetValue(obj);
            string formattedValue = FormatValue(value);

            json.AppendFormat("\"{0}\": {1}", fieldName, formattedValue);

            if (i < fields.Length - 1)
                json.Append(", ");
        }

        json.Append("}");
        return json.ToString();
    }

    // Helper method to format values as JSON.
    private static string FormatValue(object value)
    {
        if (value == null)
            return "null";
        else if (value is string || value is char)
            return $"\"{value}\"";
        else if (value is bool)
            return value.ToString().ToLower();
        else if (value.GetType().IsPrimitive)
            return value.ToString();
        else
            // For non-primitive types, attempt a recursive conversion.
            return ToJson(value);
    }
}

public class Person
{
    // Public field.
    public string FirstName = "Alice";
    // Private field.
    private int Age = 30;
    // Private field with non-string value.
    private bool IsMember = true;
}

public class Program
{
    public static void Main()
    {
        Person person = new Person();
        string jsonRepresentation = JsonConverter.ToJson(person);
        Console.WriteLine("JSON-like representation:");
        Console.WriteLine(jsonRepresentation);
    }
}
