using System;

// Interface for meal plans
interface IMealPlan {
    void ShowMeal();
}

// Meal categories implementing IMealPlan
class VegetarianMeal : IMealPlan {
	public void ShowMeal(){
		Console.WriteLine("Vegetarian Meal: Includes vegetables and grains.");
	}
}

class VeganMeal : IMealPlan {
	public void ShowMeal(){
		Console.WriteLine("Vegan Meal: 100% plant-based diet.");
	}
}

class KetoMeal : IMealPlan {
    public void ShowMeal(){
		Console.WriteLine("Keto Meal: High-fat, low-carb diet.");
	}
}

// Generic class for Meal
class Meal<T> where T : IMealPlan, new() {
    public void DisplayMeal() {
        T meal = new T(); 
        meal.ShowMeal();
    }
}

// Main program
class Program {
    static void Main() {
        Meal<VegetarianMeal> vegMeal = new Meal<VegetarianMeal>();
        Meal<VeganMeal> veganMeal = new Meal<VeganMeal>();
        Meal<KetoMeal> ketoMeal = new Meal<KetoMeal>();

        vegMeal.DisplayMeal();
        veganMeal.DisplayMeal();
        ketoMeal.DisplayMeal();
    }
}
