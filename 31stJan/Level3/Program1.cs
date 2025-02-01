using System;

public class Employee{
    // Attributes of the Employee class
    public string Name { get; set; }
    public int Id { get; set; }
    public double Salary { get; set; }

    // Method to display employee details
    public void DisplayDetails(){
        Console.WriteLine("Employee Details:");
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("ID: " + Id);
        Console.WriteLine("Salary: ₹" + Salary);
    }
}

public class Program{
    public static void Main(){
        // Creating an object of the Employee class
        Employee emp = new Employee();

        // Taking input from the user
        Console.WriteLine("Enter Employee Name: ");
        emp.Name = Console.ReadLine();

        Console.WriteLine("Enter Employee ID: ");
        emp.Id = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Employee Salary: ");
        emp.Salary = double.Parse(Console.ReadLine());

        // Calling the DisplayDetails method to display employee details
        emp.DisplayDetails();
    }
}
