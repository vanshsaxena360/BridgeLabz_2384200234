using System;

class Program{
	static void Main(string[] args){
		// initializing an array to store 10 records
		int[] age = new int[10];

		// Prompt to enter 10 ages of students
		Console.Write("Enter the Ages of 10 students\n");
		
		for(int i=0; i<age.Length; i++){
			Console.Write("Enter the age of the student "+ (i+1) +" :");
			age[i] = int.Parse(Console.ReadLine());
			
		}
		Console.WriteLine("\nEligibility to vote:");

        // Loop through the array and check voting eligibility
        for (int i = 0; i < age.Length; i++)
        {
            if (age[i] < 0) // Check for negative age
            {
                Console.WriteLine("Student "+(i + 1)+": Invalid age. Age cannot be negative.");
            }
            else if (age[i] >= 18) // Check for voting eligibility
            {
                Console.WriteLine("Student "+(i + 1)+": The student can vote.");
            }
            else // If age is less than 18
            {
                Console.WriteLine("Student "+(i + 1)+": The student cannot vote.");
            }
        }
	}
}