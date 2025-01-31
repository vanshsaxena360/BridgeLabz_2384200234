using System;

class Program
{
    static void CountVowelsAndConsonants(string str)
    {
        int vowelCount = 0, consonantCount = 0;

        // manually define lowercase and uppercase vowels
        char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

        for (int i = 0; i < str.Length; i++)
        {
            char ch = str[i];

            // check if character is an alphabet (A-Z or a-z)
            if ((ch >= 'A' && ch <= 'Z') || (ch >= 'a' && ch <= 'z'))
            {
                bool isVowel = false;

                // check if character is a vowel (manual check)
                for (int j = 0; j < vowels.Length; j++)
                {
                    if (ch == vowels[j])
                    {
                        isVowel = true;
                        break;
                    }
                }

                // update count based on whether it's a vowel or consonant
                if (isVowel)
                    vowelCount++;
                else
                    consonantCount++;
            }
        }

        // display result
        Console.WriteLine("Vowels: " + vowelCount);
        Console.WriteLine("Consonants: " + consonantCount);
    }
	static void Main()
    {
        // take input from user
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        // call method to count vowels and consonants
        CountVowelsAndConsonants(input);
    }
}
