using System;

class Program{
	static int Combination(int n){
		int combination =(n*(n-1))/2;
		return combination;
	}
	static void Main(string[] args){
		// prompt the user to input no. of students
		Console.Write("Enter the number of Students: ");
		int std = int.Parse(Console.ReadLine());
		
		// Display the output
		Console.WriteLine("Maximum no. of posible handshakes: "+Combination(std));
	}
}