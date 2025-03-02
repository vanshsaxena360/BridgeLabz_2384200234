using System;
using System.IO;
using NUnit.Framework;

// Class to handle file operations
public class FileProcessor
{
    // Method to write content to a file
    public static void WriteToFile(string filename, string content)
    {
        File.WriteAllText(filename, content);
    }

    // Method to read content from a file
    public static string ReadFromFile(string filename)
    {
        if (!File.Exists(filename))
            throw new IOException("File not found");

        return File.ReadAllText(filename);
    }
}

// NUnit Test Cases for FileProcessor
[TestFixture]
public class FileProcessorTests
{
    private string testFile = "testfile.txt";

    [SetUp]
    public void Setup()
    {
        // Ensure test file does not exist before each test
        if (File.Exists(testFile))
            File.Delete(testFile);
    }

    [Test]
    public void WriteToFile_WhenCalled_CreatesFileWithContent()
    {
        string content = "Hello, NUnit!";
        FileProcessor.WriteToFile(testFile, content);

        // Verify the file exists
        Assert.IsTrue(File.Exists(testFile));

        // Verify content is written correctly
        string readContent = File.ReadAllText(testFile);
        Assert.AreEqual(content, readContent);
    }

    [Test]
    public void ReadFromFile_WhenFileExists_ReturnsCorrectContent()
    {
        string content = "File handling test";
        File.WriteAllText(testFile, content);

        string result = FileProcessor.ReadFromFile(testFile);

        Assert.AreEqual(content, result);
    }

    [Test]
    public void ReadFromFile_WhenFileDoesNotExist_ThrowsIOException()
    {
        Assert.Throws<IOException>(() => FileProcessor.ReadFromFile("nonexistent.txt"));
    }

    [TearDown]
    public void Cleanup()
    {
        // Remove test file after each test
        if (File.Exists(testFile))
            File.Delete(testFile);
    }
}
