using System;
using System.Collections.Generic;

class InvertDictionary
{
    static Dictionary<V, List<K>> InvertMap<K, V>(Dictionary<K, V> originalMap)
    {
        Dictionary<V, List<K>> invertedMap = new Dictionary<V, List<K>>();

        foreach (var pair in originalMap)
        {
            if (!invertedMap.ContainsKey(pair.Value))
            {
                invertedMap[pair.Value] = new List<K>();
            }
            invertedMap[pair.Value].Add(pair.Key);
        }

        return invertedMap;
    }

    static void Main()
    {
        // Sample Input Dictionary
        Dictionary<string, int> inputMap = new Dictionary<string, int>
        {
            { "A", 1 },
            { "B", 2 },
            { "C", 1 }
        };

        // Invert the Dictionary
        Dictionary<int, List<string>> invertedMap = InvertMap(inputMap);

        // Display the inverted Dictionary
        Console.WriteLine("Inverted Dictionary:");
        foreach (var pair in invertedMap)
        {
            Console.Write(pair.Key+" : [");
            Console.Write(string.Join(", ", pair.Value));
            Console.WriteLine("]");
        }
    }
}
