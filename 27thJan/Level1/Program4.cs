using System;

class Program{
	// Method to calculateRounds
	static double calculateRounds(double side1, double side2, double side3){
		double perimeter =  (side1+side2+side3);
		double totalDistance = 5000;
		double rounds = (totalDistance / perimeter);
		
		return rounds;
	}
	static void Main(){
		// Prompt the user to enter 3 sides of the triangle
		Console.Write("Enter the First Side of the triangle: ");
		double side1 = double.Parse(Console.ReadLine());
		
		Console.Write("Enter the Second Side of the triangle: ");
		double side2 = double.Parse(Console.ReadLine());
		
		Console.Write("Enter the Third Side of the triangle: ");
		double side3 = double.Parse(Console.ReadLine());
		
		// display the output
		Console.WriteLine("The athlete needs to complete rounds to complete a 5 km run: "+calculateRounds(side1,side2,side3));
	}
}