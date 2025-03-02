using System;
using System.Collections;

class program{
	static void Main(){
		// Suppress the warning for non-generic collection usage.
		//#pragma warning disable CS0618  // Adjust the warning code if needed for unchecked operations

        ArrayList list = new ArrayList();
        list.Add("Hello");
        list.Add(42); // Adding an integer, no compile-time type checking

		//#pragma warning restore CS0618

        foreach (var item in list) {
            Console.WriteLine(item);
        }
	}
}