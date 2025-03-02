using System;
using System.Reflection;

public class Configuration
{
    // Private static field
    private static string API_KEY = "InitialAPIKey";

    // Helper method to display the API_KEY (for demonstration)
    public static void DisplayAPIKey()
    {
        Console.WriteLine($"Current API_KEY: {API_KEY}");
    }
}

public class Program
{
    public static void Main()
    {
        // Display the original API_KEY
        Configuration.DisplayAPIKey();

        // Get the Type object for Configuration
        Type configType = typeof(Configuration);

        // Retrieve the private static field 'API_KEY'
        FieldInfo apiKeyField = configType.GetField("API_KEY", BindingFlags.NonPublic | BindingFlags.Static);

        if(apiKeyField != null)
        {
            // Modify the value of the API_KEY field
            apiKeyField.SetValue(null, "ModifiedAPIKey");

            // Retrieve the new value of API_KEY and display it
            string newApiKey = (string)apiKeyField.GetValue(null);
            Console.WriteLine($"Modified API_KEY via Reflection: {newApiKey}");
        }
        else
        {
            Console.WriteLine("Field 'API_KEY' not found.");
        }
    }
}
