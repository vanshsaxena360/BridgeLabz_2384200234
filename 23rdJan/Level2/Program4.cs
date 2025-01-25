using System;

class Program{
	static void Main(string[] args){
		//Prompt the user to enter the weight
		Console.Write("Enter the Weight(in kg): ");
		double weight = double.Parse(Console.ReadLine());
		
		//Prompt the user to enter the height
		Console.Write("Enter the Height(in cm): ");
		double height = double.Parse(Console.ReadLine());
		
		// converting height in meter
		double heightInMeter = height/100;
		
		double BMI = weight/(heightInMeter*heightInMeter);
		Console.WriteLine("BMI is "+BMI);
		
		// output the BMI category
		if(BMI<18.4){
			Console.WriteLine("You are UnderWeight");
		}
		else if(BMI>=18.5 && BMI<24.9){
			Console.WriteLine("You are Normal weight");
		}
		else if(BMI>=25.0 && BMI<39.9){
			Console.WriteLine("You are Overweight");
		}
		else{
			Console.WriteLine("You are Obese");
		}
		
	}
}