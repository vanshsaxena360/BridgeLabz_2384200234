using System;
class Program{
	static void isNumber(int n){
		if (n==0){
			Console.WriteLine("The number is zero");
		}
		else if(n<0){
			Console.WriteLine("The number is Negative");
		}
		else{
			Console.WriteLine("The number is Positive");
		}
	}
	static void Main(string[] args){
		// Prompt the user to enter the number
		Console.Write("Enter the number: ");
		int n = int.Parse(Console.ReadLine());
		isNumber(n);
	}
}