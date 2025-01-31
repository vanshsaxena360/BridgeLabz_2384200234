using System;

class Program{
	static string LongestWord(string str){
		string longest="";
		int longestLength = 0;
		string [] words = str.Split(' ');
		for (int i = 0 ; i < words.Length ; i++) {
            if (words[i].Length > longestLength) {
                longest = words[i];
                longestLength = words[i].Length; 
            }
        }
		return longest;
	}
	static void Main(){
		// prompt the user to enter a string
		Console.Write("Enter a string: ");
		string str = Console.ReadLine();
		
		Console.WriteLine("Longest Word in this string is "+LongestWord(str));
	}
}