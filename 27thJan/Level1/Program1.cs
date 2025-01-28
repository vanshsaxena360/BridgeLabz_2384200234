using System;

class Program{
	// creating a methods which returns a integer value
	static int simpleInterest(int principal, int rate, int time){
		int simpleInterest = (principal*rate*time)/100;
		return simpleInterest;
	}
	
	static void Main(){
		// prompt the user to enter details
		Console.Write("Enter Principal amount: ");
		int principal = int.Parse(Console.ReadLine());
		
		Console.Write("Enter the rate: ");
		int rate = int.Parse(Console.ReadLine());
		
		Console.Write("Enter the time: ");
		int time = int.Parse(Console.ReadLine());
		
		// display the simpleInterest
		Console.WriteLine("The Simple Interest is: "+simpleInterest(principal,rate,time));
		
	}
}