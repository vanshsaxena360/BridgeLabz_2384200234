using System;

public class BMICalculator2DArray
{
    public static void Main(string[] args)
    {
        // Take input for the number of persons
        Console.WriteLine("Enter the number of persons:");
        int numberOfPersons = int.Parse(Console.ReadLine());

        // Create a 2D array to store weight, height, and BMI
        double[][] personData = new double[numberOfPersons][];
        for (int i = 0; i < numberOfPersons; i++)
        {
            personData[i] = new double[3]; // [0]: weight, [1]: height, [2]: BMI
        }

        // Create an array to store weight status
        string[] weightStatus = new string[numberOfPersons];

        // Input weight and height for each person
        for (int i = 0; i < numberOfPersons; i++)
        {
            Console.WriteLine("Enter weight of person "+(i + 1));
            double weight = double.Parse(Console.ReadLine()) ;
            
            personData[i][0] = weight;

            Console.WriteLine("Enter height (in meters) of person "+(i + 1));
            double height = double.Parse(Console.ReadLine());
            
            personData[i][1] = height;

            // Calculate BMI
            personData[i][2] = weight / (height * height);

            // Determine weight status
            double bmi = personData[i][2];
            if (bmi < 18.5)
                weightStatus[i] = "Underweight";
            else if (bmi >= 18.5 && bmi <= 24.9)
                weightStatus[i] = "Normal weight";
            else if (bmi >= 25 && bmi <= 39.9)
                weightStatus[i] = "Overweight";
            else
                weightStatus[i] = "Obesity";
        }

        // Display results
        Console.WriteLine("\nResults:");
        Console.WriteLine("Person\tHeight(m)\tWeight(kg)\tBMI\t\tWeight Status");
        for (int i = 0; i < numberOfPersons; i++)
        {
            Console.WriteLine(
                (i + 1) + "\t" +
                personData[i][1].ToString("F2") + "\t\t" +
                personData[i][0].ToString("F2") + "\t\t" +
                personData[i][2].ToString("F2") + "\t\t" +
                weightStatus[i]);
        }
    }
}
