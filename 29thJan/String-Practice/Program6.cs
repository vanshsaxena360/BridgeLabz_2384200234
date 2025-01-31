using System;

class Program{
	static int countOccurance(string str, string subStr){
		int count=0;
		int strLen = str.Length, subStrLen = subStr.Length;
		
		for(int i=0;i<=strLen-subStrLen;i++){
			int j;
			for(j=0;j<subStrLen; j++){
				if(str[i+j] != subStr[j]){
					break;
				}
			}
			if(j==subStrLen){
				count++;
				
			}
		}
		return count;
	}
	static void Main(){
		// Prompt the user to enter a string
		Console.Write("Enter a string: ");
		string str = Console.ReadLine();
		
		// prompt the user to enter a sub string
		Console.Write("Enter a sub string: ");
		string subStr = Console.ReadLine();
		
		Console.WriteLine("The count is "+countOccurance(str, subStr));
	}
}