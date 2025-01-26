using System;

class Program{
	static void Main(string[] args){
		// initializing an array to store 5 numbers
		int [] num = new int[5];
		
		// Prompt the user to enter 5 numbers
		Console.Write("Enter 5 numbers :\n");
		
		for(int i=0; i<num.Length; i++){
			Console.Write("Enter no. "+ (i+1) +" :");
			num[i] = int.Parse(Console.ReadLine());
		}
		
		for(int i=0; i<num.Length; i++){
			if(num[i]<i){
				Console.WriteLine("Your number "+num[i]+" is Negative");
			}
			else if(num[i]==0){
				Console.WriteLine("Your number "+num[i]+" is Zero");
			}
			else{
				if(num[i]%2==0){
					Console.WriteLine("Your number "+num[i]+" is Positive and even");
				}
				else{
					Console.WriteLine("Your number "+num[i]+" is Positive and odd");
				}
			}
		}
		
		if(num[0]>num[num.Length-1]){
			Console.WriteLine(num[0]+" is greater than last element");
		}
		else if(num[0]==num[num.Length-1]){
			Console.WriteLine(num[0]+" is equal to last element");
		}
		else{
			Console.WriteLine(num[0]+" is less than last element");
		}
	} 
}