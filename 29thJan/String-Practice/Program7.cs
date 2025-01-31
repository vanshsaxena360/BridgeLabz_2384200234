using System;

class Program{
	public static string ToggleCase(string givenString) {
        string toggledString = "";
        foreach (char ch in givenString) {
            if ((int) ch >=97) {
                toggledString += (char) ((int) ch - 32) ;
            }
            else {
                toggledString += (char) ((int) ch + 32) ;
            }
        }
        return toggledString;
    }
	static void Main(){
		// prompt the user to enter a string
		Console.Write("Enter a string: ");
		string str = Console.ReadLine();
		
		Console.WriteLine("Toggle case string is: "+ToggleCase(str));
	}
}