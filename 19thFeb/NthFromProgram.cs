using System;
using System.Collections.Generic;

class NthFromProgram{
	public static string FindNthFromEnd(LinkedList<string> list, int n){
		LinkedListNode<string> first = list.First;
		LinkedListNode<string> second = list.First;
		
		// move the first pointer n steps ahead
		for(int i=0; i<n; i++){
			if(first == null){
				return "N is greater than the size of the list";
			}
			first = first.Next;
		}
		
		// move both pointer one step at a time until first reaches the end
		while(first != null){
			first = first.Next;
			second = second.Next;
		}
		return second.Value;
	}
	static void Main(){
		LinkedList<string> linkedList = new LinkedList<string>(new string[] {"A","B","C","D","E"});
		int N = 2;
		
		string result = FindNthFromEnd(linkedList, N);
		Console.WriteLine("The "+N+"th element from the end is: "+result);
	}
}