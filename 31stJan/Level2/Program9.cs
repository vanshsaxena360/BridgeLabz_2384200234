using System;

public class BasicCalculator
{
    // Method for Addition
    public static double Add(double a, double b){
        return a + b;
    }

    // Method for Subtraction
    public static double Subtract(double a, double b){
        return a - b;
    }

    // Method for Multiplication
    public static double Multiply(double a, double b){
        return a * b;
    }

    // Method for Division
    public static double Divide(double a, double b){
        if (b == 0){
            Console.WriteLine("Error: Division by zero is not allowed.");
            return double.NaN; // Return Not-a-Number
        }
        return a / b;
    }

    // Main method
    public static void Main(){
        while (true){
            Console.WriteLine("\nBasic Calculator");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an operation (1-5): ");

            int choice=int.Parse(Console.ReadLine());            

            if (choice == 5){
                Console.WriteLine("Exiting program. Goodbye!");
                break;
            }

            Console.Write("Enter the first number: ");
            double num1 = double.Parse(Console.ReadLine());
            

            Console.Write("Enter the second number: ");
            double num2 = double.Parse(Console.ReadLine());

            double result = 0;

            switch (choice){
                case 1:
                    result = Add(num1, num2);
                    Console.WriteLine("Result: {0} + {1} = {2}",num1,num2,result);
                    break;
                case 2:
                    result = Subtract(num1, num2);
                    Console.WriteLine("Result: {0} - {1} = {2}",num1,num2,result);
                    break;
                case 3:
                    result = Multiply(num1, num2);
                    Console.WriteLine("Result: {0} * {1} = {2}",num1,num2,result);
                    break;
                case 4:
                    result = Divide(num1, num2);
					// Check if division was valid
                    if (!double.IsNaN(result)){
                        Console.WriteLine("Result: {0} / {1} = {2}",num1,num2,result);
                    }
                    break;
            }
        }
    }
}
