using System;
using System.Collections.Generic;

class RotateListProgram{
	public static List<int> RotateList(List<int> list, int positions){
		int n = list.Count;
		if(n==0) return list; // if list empty
		positions = positions%n;
		
		// create a new list with rotated elements
		List<int> rotatedList = new List<int>();
		
		// add elements from the positions index to the end
		for(int i=positions; i<n; i++){
			rotatedList.Add(list[i]);
		}
		
		// add the first positions elements to the end
		for(int i=0; i<positions; i++){
			rotatedList.Add(list[i]);
		}
		return rotatedList;
	}
	static void Main(){
		List<int> input = new List<int>{10,20,30,40,50};
		int rotateBy = 2;
		
		List<int> rotated = RotateList(input, rotateBy);
		
		Console.WriteLine("Rotated List: "+string.Join(", ",rotated));
	}
}