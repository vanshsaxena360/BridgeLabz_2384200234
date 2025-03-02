using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "large_students.csv"; // Path to the large CSV file
        int chunkSize = 100; // Number of lines to process at a time
        int totalRecordsProcessed = 0;

        if (!File.Exists(filePath))
        {
            Console.WriteLine("File not found!");
            return;
        }

        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string headerLine = reader.ReadLine(); // Read and skip header
                string line;
                int lineCount = 0;

                while ((line = reader.ReadLine()) != null)
                {
                    lineCount++;
                    totalRecordsProcessed++;

                    // Process the line (Example: just printing it, but can be modified as needed)
                    // Console.WriteLine(line);

                    if (lineCount == chunkSize)
                    {
                        Console.WriteLine($"Processed {totalRecordsProcessed} records so far...");
                        lineCount = 0;
                    }
                }
            }

            Console.WriteLine($"Finished processing. Total records processed: {totalRecordsProcessed}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error reading the file: " + ex.Message);
        }
    }
}
