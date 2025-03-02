using System;
using System.Collections.Generic;

class FrequencyCounter{
	public static Dictionary<string, int> CountFrequency(List<string> words){
		Dictionary<string, int> frequencyMap = new Dictionary<string, int>();
		
		foreach(string word in words){
			if(frequencyMap.ContainsKey(word)){
				frequencyMap[word]++; // add count if the word exists
			}
			else{
				frequencyMap[word] = 1; // add word with initial count 1
			}
		}
		return frequencyMap;
	}
	static void Main(){
		List<string> input = new List<string>{"apple","banana","apple","orange"};
		Dictionary<string, int> result = CountFrequency(input);
		
		Console.WriteLine("Word Frequencies:");
		foreach(var pair in result){
			Console.WriteLine(pair.Key+" : "+pair.Value);
		}
	}
}