using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

class Program
{
    static void Main()
    {
        // 1. Create a JSON object for a Student
        var student = new
        {
            Name = "John Doe",
            Age = 20,
            Subjects = new string[] { "Math", "Science", "English" }
        };
        string studentJson = JsonConvert.SerializeObject(student, Formatting.Indented);
        Console.WriteLine("Student JSON:\n" + studentJson);

        // 2. Convert a C# object (Car class) into JSON format
        Car car = new Car { Make = "Toyota", Model = "Corolla", Year = 2020 };
        string carJson = JsonConvert.SerializeObject(car, Formatting.Indented);
        Console.WriteLine("\nCar JSON:\n" + carJson);

        // 3. Read a JSON file and extract specific fields
        string jsonFilePath = "data.json"; // Assume this file exists
        if (File.Exists(jsonFilePath))
        {
            string jsonData = File.ReadAllText(jsonFilePath);
            JArray jsonArray = JArray.Parse(jsonData);
            foreach (var item in jsonArray)
            {
                Console.WriteLine($"Name: {item["name"]}, Email: {item["email"]}");
            }
        }

        // 4. Merge two JSON objects into one
        JObject obj1 = JObject.Parse("{ 'name': 'Alice', 'age': 30 }");
        JObject obj2 = JObject.Parse("{ 'email': 'alice@example.com', 'city': 'New York' }");
        obj1.Merge(obj2, new JsonMergeSettings { MergeArrayHandling = MergeArrayHandling.Union });
        Console.WriteLine("\nMerged JSON:\n" + obj1.ToString());

        // 5. Validate JSON structure using Newtonsoft.Json.Schema
        string jsonSchema = @"{
            'type': 'object',
            'properties': {
                'name': {'type': 'string'},
                'age': {'type': 'integer'},
                'email': {'type': 'string'}
            },
            'required': ['name', 'age']
        }";

        JSchema schema = JSchema.Parse(jsonSchema);
        JObject testJson = JObject.Parse("{ 'name': 'Bob', 'age': 25 }");
        bool isValid = testJson.IsValid(schema, out IList<string> errors);
        Console.WriteLine("\nJSON is valid: " + isValid);
        if (!isValid) Console.WriteLine("Errors: " + string.Join(", ", errors));

        // 6. Convert a list of C# objects into a JSON array
        List<Car> cars = new List<Car>
        {
            new Car { Make = "Ford", Model = "Mustang", Year = 2022 },
            new Car { Make = "Honda", Model = "Civic", Year = 2021 }
        };
        string carsJson = JsonConvert.SerializeObject(cars, Formatting.Indented);
        Console.WriteLine("\nList of Cars JSON:\n" + carsJson);

        // 7. Parse JSON and filter only records where age > 25
        string peopleJson = "[ { 'name': 'Alice', 'age': 30 }, { 'name': 'Bob', 'age': 22 }, { 'name': 'Charlie', 'age': 27 } ]";
        JArray peopleArray = JArray.Parse(peopleJson);
        var filteredPeople = peopleArray.Where(p => (int)p["age"] > 25);
        Console.WriteLine("\nFiltered People (age > 25):\n" + JsonConvert.SerializeObject(filteredPeople, Formatting.Indented));
    }
}

class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
}