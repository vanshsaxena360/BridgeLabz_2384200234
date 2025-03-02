using System;
using System.Collections.Generic;

class RemoveDuplicateProgram{
	public static List<int> RemoveDuplicates(List<int> list){
		HashSet<int> seen = new HashSet<int>(); // track seen elements
		List<int> result = new List<int>(); //store unique elements in order
		
		foreach(int num in list){
			if(!seen.Contains(num)){ // if the number is not in HashSet, add it
				seen.Add(num);
				result.Add(num);
			}
		}
		return result;
	}
	static void Main(){
		List<int> input = new List<int>{3,1,2,2,3,4};
		List<int> uniqueList = RemoveDuplicates(input);
				
		Console.WriteLine("List Before removing duplicates: "+string.Join(", ",input));
		Console.WriteLine("List after removing duplicates: "+string.Join(", ",uniqueList));
	}
}