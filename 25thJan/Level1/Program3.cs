using System;

class Program{
	static void Main(string[] args){
		// prompt to enter a number
		Console.Write("Enter the number to get its multiplication table :");
		int num = int.Parse(Console.ReadLine());
		
		// initializing a array to store 10 multiplication of a number
		int[] multi = new int[10];
		
		//for loop to create multiplication table
		for (int i=0; i<multi.Length; i++){
			multi[i] = num*(i+1);
		}
		// finally printing the multiplication table
		Console.WriteLine("The multiplication table is");
		for(int i=0; i<multi.Length; i++){
			Console.WriteLine(num+" X "+(i+1)+" = "+multi[i]);
		}
	}
}