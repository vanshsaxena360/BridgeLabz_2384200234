using System;

public class Book
{
    // Attributes for title, author, and price
    public string Title { get; set; }
    public string Author { get; set; }
    public double Price { get; set; }

    // Method to display book details
    public void DisplayBookDetails()
    {
        Console.WriteLine("Book Title: " + Title);
        Console.WriteLine("Author: " + Author);
        Console.WriteLine("Price: ₹" + Price);
    }
}

public class Program
{
    public static void Main()
    {
        // Create an instance of Book class
        Book book = new Book();

        // Taking input for book details
        Console.WriteLine("Enter the book title: ");
        book.Title = Console.ReadLine();
        
        Console.WriteLine("Enter the author's name: ");
        book.Author = Console.ReadLine();
        
        Console.WriteLine("Enter the price of the book: ");
        book.Price = double.Parse(Console.ReadLine());

        // Calling method to display book details
        book.DisplayBookDetails();
    }
}
