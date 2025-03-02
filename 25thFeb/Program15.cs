using System;
using System.IO;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

class Program
{
    private static RSA rsa;

    static void Main()
    {
        rsa = RSA.Create();
        string originalFilePath = "employees.csv";
        string encryptedFilePath = "encrypted_employees.csv";
        string decryptedFilePath = "decrypted_employees.csv";

        // Encrypt and write to CSV
        EncryptAndWriteCsv(originalFilePath, encryptedFilePath);

        // Decrypt and read CSV
        DecryptAndReadCsv(encryptedFilePath, decryptedFilePath);
    }

    static void EncryptAndWriteCsv(string inputFilePath, string outputFilePath)
    {
        if (!File.Exists(inputFilePath))
        {
            Console.WriteLine("Input file not found!");
            return;
        }

        try
        {
            using (StreamReader reader = new StreamReader(inputFilePath))
            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                string header = reader.ReadLine();
                writer.WriteLine(header); // Write header as is
                
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] values = line.Split(',');
                    
                    // Encrypt sensitive fields (Salary, Email)
                    values[2] = Encrypt(values[2]); // Salary
                    values[3] = Encrypt(values[3]); // Email
                    
                    writer.WriteLine(string.Join(",", values));
                }
            }
            Console.WriteLine("Data encrypted and written to file successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error encrypting data: " + ex.Message);
        }
    }

    static void DecryptAndReadCsv(string inputFilePath, string outputFilePath)
    {
        if (!File.Exists(inputFilePath))
        {
            Console.WriteLine("Encrypted file not found!");
            return;
        }

        try
        {
            using (StreamReader reader = new StreamReader(inputFilePath))
            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                string header = reader.ReadLine();
                writer.WriteLine(header); // Write header as is
                
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] values = line.Split(',');
                    
                    // Decrypt sensitive fields (Salary, Email)
                    values[2] = Decrypt(values[2]); // Salary
                    values[3] = Decrypt(values[3]); // Email
                    
                    writer.WriteLine(string.Join(",", values));
                }
            }
            Console.WriteLine("Data decrypted and written to file successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error decrypting data: " + ex.Message);
        }
    }

    static string Encrypt(string text)
    {
        byte[] data = Encoding.UTF8.GetBytes(text);
        byte[] encryptedData = rsa.Encrypt(data, RSAEncryptionPadding.OaepSHA256);
        return Convert.ToBase64String(encryptedData);
    }

    static string Decrypt(string encryptedText)
    {
        byte[] data = Convert.FromBase64String(encryptedText);
        byte[] decryptedData = rsa.Decrypt(data, RSAEncryptionPadding.OaepSHA256);
        return Encoding.UTF8.GetString(decryptedData);
    }
}
