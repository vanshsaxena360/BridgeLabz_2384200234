using System;
using System.Collections.Generic;

// abstract class for warehouse items
abstract class WarehouseItem{
	public string Name {get; set;}
	public double Price {get; set;}
	
	public WarehouseItem(string name, double price){
		Name = name;
		Price = price;
	}
	
	// abstract method for displaying details
	public abstract void DisplayInfo();
}
// electronics items
class Electronics : WarehouseItem{
	public string Brand{get; set;}
	
	public Electronics(string name, double price, string brand) : base(name,price){
		Brand = brand;
	}
	public override void DisplayInfo(){
		Console.WriteLine("[Electronics] "+Name+" - "+Brand+", Price: "+Price);
	}
}
// Geoceries items
class Geoceries : WarehouseItem{
	public string ExpiryDate {get; set;}
	
	public Geoceries(string name, double price, string expiryDate): base(name,price){
		ExpiryDate = expiryDate;
	}
	
	public override void DisplayInfo(){
		Console.WriteLine("[Geoceries] "+Name+" - Expiry: "+ExpiryDate+", Price: "+Price);
	}
}
// Furniture items
class Furniture : WarehouseItem{
	public string Material {get; set;}
	
	public Furniture(string name, double price, string material): base(name,price){
		Material = material;
	}
	public override void DisplayInfo(){
		Console.WriteLine("[Furniture] "+Name+" - Material: "+Material+", Price: "+Price);
	}
}

// generic storage class for warehouse items
class Storage<T> where T : WarehouseItem{
	private List<T> items = new List<T>();
	
	public void AddItem(T item){
		items.Add(item);
	}
	
	public void DisplayItems(){
		Console.WriteLine("\nDisplaying "+typeof(T).Name+" Items:");
		foreach(var item in items){
			item.DisplayInfo();
		}
	}
}
// main program
class Program{
	static void Main(){
		// creating storage for different item types
		Storage<Electronics> electronicsStorage = new Storage<Electronics>();
		Storage<Geoceries> groceriesStorage = new Storage<Geoceries>();
		Storage<Furniture> furnitureStorage = new Storage<Furniture>();
		
		// adding items to storage
		electronicsStorage.AddItem(new Electronics("Laptop",200000,"Dell"));
		
		groceriesStorage.AddItem(new Geoceries("Milk",40,"2025-01-01"));
		
		furnitureStorage.AddItem(new Furniture("Chair",500,"Wood"));
		
		// displaying items
		electronicsStorage.DisplayItems();
		groceriesStorage.DisplayItems();
		furnitureStorage.DisplayItems();
		
		
	}
}