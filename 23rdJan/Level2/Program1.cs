using System;

class Program{
	static void Main(string[] args){
		// Prompt the user to enter the year
		Console.Write("Enter the year: ");
		int year = int.Parse(Console.ReadLine());
		// if statement to check the year after 1582
		if (year<=1582){
			Console.WriteLine("Enter the year after 1582");
		}
		else{
			// if and nested if statements to check whether is the leap year or not
			if((year%4==0 && year%100!=0) ||(year%400==0)){
				Console.WriteLine("This is the leap year");
			}
			else{
				Console.WriteLine("Not a leap year");
			}
		}		
	}
}