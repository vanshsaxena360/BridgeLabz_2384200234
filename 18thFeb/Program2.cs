using System;

abstract class ProductCategory{
	public string Name {get; set;}
	public ProductCategory(string name){
		Name = name;
	}
}

class BookCategory: ProductCategory{
	public BookCategory() : base("Book"){}
}

class ClothingCategory : ProductCategory{
	public ClothingCategory() : base("Clothing"){}
}

class Product<T> where T : ProductCategory{
	public string Name {get; set;}
	public double Price {get; set;}
	public T Category {get; set;}
	
	public Product(string name, double price, T category){
		Name = name;
		Price = price;
		Category = category;
	}
	
	public void DisplayInfo(){
		Console.WriteLine("[Category: "+Category.Name+"] "+Name+" - Price: "+Price);
	}
}
class Marketplace{
	public static void ApplyDiscount<T>(Product<T> product, double percentage) where T : ProductCategory{
		product.Price -= product.Price * (percentage/100);
		Console.WriteLine("Discount applied! new price of "+product.Name+", Price: "+product.Price);
	}
}

class Program{
	static void Main(){
		Product<BookCategory> book = new Product<BookCategory>("C-Sharp Programming",1000,new BookCategory());
		Product<ClothingCategory> shirt = new Product<ClothingCategory>("T-shirt",500,new ClothingCategory());
		Console.WriteLine();
		
		book.DisplayInfo();
		shirt.DisplayInfo();
		Console.WriteLine();
		
		Marketplace.ApplyDiscount(book,10);
		Marketplace.ApplyDiscount(shirt,12);
		Console.WriteLine();
		
		book.DisplayInfo();
		shirt.DisplayInfo();
	}
}