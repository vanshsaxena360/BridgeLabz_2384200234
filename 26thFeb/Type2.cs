using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

class Program
{
    static void Main()
    {
        // 1. Read a JSON file and print all keys and values
        string jsonFilePath = "data.json";
        if (File.Exists(jsonFilePath))
        {
            string jsonData = File.ReadAllText(jsonFilePath);
            JObject jsonObject = JObject.Parse(jsonData);
            foreach (var item in jsonObject)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }
        }

        // 2. Convert a list of C# objects into a JSON array
        List<Car> cars = new List<Car>
        {
            new Car { Make = "Ford", Model = "Mustang", Year = 2022 },
            new Car { Make = "Honda", Model = "Civic", Year = 2021 }
        };
        string carsJson = JsonConvert.SerializeObject(cars, Formatting.Indented);
        Console.WriteLine("\nList of Cars JSON:\n" + carsJson);

        // 3. Filter JSON data: Print only users older than 25 years
        string peopleJson = "[ { 'name': 'Alice', 'age': 30 }, { 'name': 'Bob', 'age': 22 }, { 'name': 'Charlie', 'age': 27 } ]";
        JArray peopleArray = JArray.Parse(peopleJson);
        var filteredPeople = peopleArray.Where(p => (int)p["age"] > 25);
        Console.WriteLine("\nFiltered People (age > 25):\n" + JsonConvert.SerializeObject(filteredPeople, Formatting.Indented));

        // 4. Validate an email field using JSON Schema
        string jsonSchema = @"{
            'type': 'object',
            'properties': {
                'name': {'type': 'string'},
                'age': {'type': 'integer'},
                'email': {'type': 'string', 'format': 'email'}
            },
            'required': ['name', 'age', 'email']
        }";
        
        JSchema schema = JSchema.Parse(jsonSchema);
        JObject testJson = JObject.Parse("{ 'name': 'Bob', 'age': 25, 'email': 'bob@example.com' }");
        bool isValid = testJson.IsValid(schema, out IList<string> errors);
        Console.WriteLine("\nJSON is valid: " + isValid);
        if (!isValid) Console.WriteLine("Errors: " + string.Join(", ", errors));

        // 5. Merge two JSON files into a single JSON object
        string jsonFilePath2 = "data2.json";
        if (File.Exists(jsonFilePath) && File.Exists(jsonFilePath2))
        {
            JObject obj1 = JObject.Parse(File.ReadAllText(jsonFilePath));
            JObject obj2 = JObject.Parse(File.ReadAllText(jsonFilePath2));
            obj1.Merge(obj2, new JsonMergeSettings { MergeArrayHandling = MergeArrayHandling.Union });
            Console.WriteLine("\nMerged JSON:\n" + obj1.ToString());
        }

        // 6. Convert JSON to XML format
        string xmlData = JsonConvert.DeserializeXNode(File.ReadAllText(jsonFilePath), "Root").ToString();
        Console.WriteLine("\nJSON to XML:\n" + xmlData);

        // 7. Convert CSV data into JSON
        string csvData = "Name,Age,Email\nJohn,30,john@example.com\nJane,25,jane@example.com";
        var csvLines = csvData.Split('\n').Select(line => line.Split(','));
        var headers = csvLines.First();
        var csvJsonArray = new JArray(
            csvLines.Skip(1).Select(line => new JObject(
                headers.Zip(line, (header, value) => new JProperty(header, value))
            ))
        );
        Console.WriteLine("\nCSV to JSON:\n" + csvJsonArray.ToString());

        // 8. Generate a JSON report from database records (Mock example)
        List<Car> dbCars = new List<Car>
        {
            new Car { Make = "Tesla", Model = "Model S", Year = 2023 },
            new Car { Make = "BMW", Model = "X5", Year = 2022 }
        };
        string dbReportJson = JsonConvert.SerializeObject(dbCars, Formatting.Indented);
        Console.WriteLine("\nDatabase Report JSON:\n" + dbReportJson);
    }
}

class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
}