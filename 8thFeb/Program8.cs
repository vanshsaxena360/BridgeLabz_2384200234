using System;

class BaseClass  
{  
    public virtual void ShowMessage(string message)  
    {  
        Console.WriteLine("Base: " + message);  
    }  
}  

class DerivedClass : BaseClass  
{  
    public override void ShowMessage(string message)  
    {  
        Console.WriteLine("Derived: " + message);  
    }  

    // Clearly separate the new method with a distinct name
    public void ShowNumber(int number)  
    {  
        Console.WriteLine("Show Number: " + number);  
    }  
}  

class Program  
{  
    static void Main()  
    {  
        BaseClass obj1 = new DerivedClass();  
        obj1.ShowMessage("Hello"); // Calls overridden method

        DerivedClass obj2 = new DerivedClass();
        obj2.ShowNumber(42); // Calls distinct method
    }  
}
