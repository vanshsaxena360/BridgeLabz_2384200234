using System;
using System.IO;

class Program
{
    static void Main()
    {
        try
        {
            // Using 'using' statement to ensure StreamReader is properly disposed
            using (StreamReader reader = new StreamReader("info.txt"))
            {
                string firstLine = reader.ReadLine();
                Console.WriteLine("First line of the file: " + firstLine);
            }
        }
        catch (IOException)
        {
            // Handling exception if file does not exist or cannot be read
            Console.WriteLine("Error reading file");
        }
    }
}
