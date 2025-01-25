using System;

class Program{
	static void Main(string[] args){
		// Input all the three subjects marks
		Console.Write("Enter marks for Physics: ");
		double physics = double.Parse(Console.ReadLine());
		
		Console.Write("Enter marks for Chemistry: ");
		double chemistry = double.Parse(Console.ReadLine());
		
		Console.Write("Enter marks for Maths: ");
		double maths = double.Parse(Console.ReadLine());
		
		// total (average percent) marks
		double avgPercent = (physics + chemistry + maths)/3;
		
		// Initialize grade and marks
		string grade= "";
		string remarks= "";
		
		// Determine grade and remarks based on the average percentage
        if (avgPercent >= 80)
        {
            grade = "A";
            remarks = "Level 4, above agency-normalized standards";
        }
        else if (avgPercent >= 70)
        {
            grade = "B";
            remarks = "Level 3, at agency-normalized standards";
        }
        else if (avgPercent >= 60)
        {
            grade = "C";
            remarks = "Level 2, below but approaching agency-normalized standards";
        }
        else if (avgPercent >= 50)
        {
            grade = "D";
            remarks = "Level 1, well below agency-normalized standards";
        }
        else if (avgPercent >= 40)
        {
            grade = "E";
            remarks = "Level 1-, too below agency-normalized standards";
        }
        else
        {
            grade = "R";
            remarks = "Remedial standards";
        }
		
		// output the result
		Console.WriteLine("Average Percentage "+avgPercent+
						  "\nGrade "+grade+
						  "\nRemarks "+remarks);
		
	}
}