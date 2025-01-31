using System;

class Program{
	static string reverseString(string str){
		// creating a character array 
		char[] reverseArray = new char[str.Length];
		int j=0;
		
		// storing all the character of a given string in the char array in the reverse order
		for (int i=str.Length-1	; i>=0; i--){
			reverseArray[j]=str[i];
			j++;
		}
		// creating another string to store reverse string
		string reversedStr = "";
		for(int i=0; i<reverseArray.Length; i++){
			reversedStr += reverseArray[i];
		}
		return reversedStr;
	}
	static void Main(string[] args){
		// prompt the user to enter a string
		Console.Write("Enter a string: ");
		string str = Console.ReadLine();
		
		// display the output
		Console.WriteLine(reverseString(str));
	}
}