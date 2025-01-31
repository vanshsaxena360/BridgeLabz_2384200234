using System;

class Program{
	static bool palindrome(string str){
		int length = str.Length;
		
		for(int i=0; i<length/2; i++){
			if(str[i] != str[length-i-1]){
				return false;
			}
		}
		return true;
	}
	static void Main(){
		// Prompt the user to enter a string
		Console.Write("Enter a string: ");
		string str = Console.ReadLine();
	
		// check if the string is palindrome
        bool isPalindrome = palindrome(str);

        // display result
        if (isPalindrome)
            Console.WriteLine("The string is a Palindrome.");
        else
            Console.WriteLine("The string is NOT a Palindrome.");
	}
}