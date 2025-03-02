using System;
using System.Collections.Generic;
using System.Linq;

class ShoppingCart
{
    private Dictionary<string, double> cart = new Dictionary<string, double>();  // Stores products and prices
    private SortedDictionary<double, List<string>> sortedCart = new SortedDictionary<double, List<string>>(); // Sorted by price

    public void AddItem(string product, double price)
    {
        cart[product] = price; // Add product

        if (!sortedCart.ContainsKey(price))
            sortedCart[price] = new List<string>();
        sortedCart[price].Add(product);
    }

    public void DisplayCart()
    {
        Console.WriteLine("\nShopping Cart (Insertion Order):");
        foreach (var item in cart)
            Console.WriteLine(item.Key + ": Price " + item.Value);
    }

    public void DisplaySortedByPrice()
    {
        Console.WriteLine("\nShopping Cart (Sorted by Price):");
        foreach (var entry in sortedCart)
            foreach (var product in entry.Value)
                Console.WriteLine(product + ": Price " + entry.Key);
    }
}

class Program
{
    static void Main()
    {
        ShoppingCart cart = new ShoppingCart();

        // Adding items to the cart
        cart.AddItem("Laptop", 120000);
        cart.AddItem("Phone", 80000);
        cart.AddItem("Headphones", 15000);
        cart.AddItem("Keyboard", 1000);
        cart.AddItem("Mouse", 500);
        cart.AddItem("Monitor", 30000);

        // Display Cart
        cart.DisplayCart();
        cart.DisplaySortedByPrice();
    }
}
