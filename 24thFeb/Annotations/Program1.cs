using System;

// parent class
class Animal{
	public virtual void MakeSound(){ // virtual method to allow overriding
		Console.WriteLine("Some generic animal sound");
	}
}

// derived class
class Dog : Animal{
	public override void MakeSound(){
		Console.WriteLine("Dog Barking");
	}
}

// Main program
class Program{
	static void Main(){
		Animal myDog = new Dog(); // polymorphism
		myDog.MakeSound(); // calls the override method in dog class
	}
}