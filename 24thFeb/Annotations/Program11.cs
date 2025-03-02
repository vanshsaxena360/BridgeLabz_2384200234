using System;
using System.Reflection;
using System.Text;
using System.Collections.Generic;

// Step 1: Define the JsonField attribute.
[AttributeUsage(AttributeTargets.Field)]
public class JsonFieldAttribute : Attribute
{
    public string Name { get; set; }
    
    public JsonFieldAttribute(string name)
    {
        Name = name;
    }
}

// Step 2: Create a User class with fields decorated with JsonField.
public class User
{
    [JsonField("user_name")]
    public string Username;
    
    [JsonField("user_age")]
    public int Age;
    
    // This field won't be serialized because it lacks the attribute.
    public string Password;
    
    public User(string username, int age, string password)
    {
        Username = username;
        Age = age;
        Password = password;
    }
}

// Step 3: Create a simple serializer method to build a JSON string.
public static class SimpleJsonSerializer
{
    public static string Serialize(object obj)
    {
        if (obj == null)
            return "null";
        
        Type type = obj.GetType();
        var sb = new StringBuilder();
        sb.Append("{");

        List<string> jsonFields = new List<string>();

        // Iterate over each field in the object.
        foreach (FieldInfo field in type.GetFields(BindingFlags.Public | BindingFlags.Instance))
        {
            // Check if the field has a JsonField attribute.
            var attr = field.GetCustomAttribute<JsonFieldAttribute>();
            if (attr != null)
            {
                string jsonKey = attr.Name;
                object fieldValue = field.GetValue(obj);
                string jsonValue;

                // If the field value is a string, enclose it in quotes.
                if (fieldValue is string)
                {
                    jsonValue = $"\"{fieldValue}\"";
                }
                else
                {
                    jsonValue = fieldValue?.ToString() ?? "null";
                }
                
                jsonFields.Add($"\"{jsonKey}\": {jsonValue}");
            }
        }

        sb.Append(string.Join(", ", jsonFields));
        sb.Append("}");
        return sb.ToString();
    }
}

// Step 4: Demonstrate usage.
public class Program
{
    public static void Main()
    {
        User user = new User("Alice", 30, "SecretPassword");
        string json = SimpleJsonSerializer.Serialize(user);
        Console.WriteLine("Serialized JSON:");
        Console.WriteLine(json);
    }
}
