using System;
using System.Collections.Generic;

class ReverseListProgram{
	// reverse list using the two pointer approach
	public static void ReverseList<T>(List<T> list){
		int left=0, right=list.Count-1;
		while(left<right){
			// swap elements
			T temp = list[left];
			list[left] = list[right];
			list[right] = temp;
			left++;
			right--;
		}
	}
	
	// reverse linkedlist using iteration
	public static LinkedList<T> ReverseLinkedList<T>(LinkedList<T> list){
		LinkedList<T> reversedList = new LinkedList<T>();
		foreach(T item in list){
			reversedList.AddFirst(item);
		}
		return reversedList;
	}
	static void Main(){
		// Example with List<int> (ArrayList equivalent)
		
		List<int> arrayList = new List<int> {1,2,3,4,5};
		Console.WriteLine("Original List: "+ string.Join(", ",arrayList));
		ReverseList(arrayList);
		Console.WriteLine("Reverse List: "+ string.Join(", ",arrayList));
		
		// example with linkedlist
		
		LinkedList<int> linkedlist = new LinkedList<int>(new int[] {1,2,3,4,5});
		Console.WriteLine("\nOriginal LinkedList: "+string.Join(", ",linkedlist));
		LinkedList<int> reversedLinkedList = ReverseLinkedList(linkedlist);
		Console.WriteLine("Reverse LinkedList: "+string.Join(", ",reversedLinkedList));
	}
}