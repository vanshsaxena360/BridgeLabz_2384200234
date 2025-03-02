using System;
using System.Collections.Generic;
using NUnit.Framework;

// ListManager class with list operations
public class ListManager
{
    // Method to add an element to the list
    public static void AddElement(List<int> list, int element)
    {
        list.Add(element);
    }

    // Method to remove an element from the list
    public static bool RemoveElement(List<int> list, int element)
    {
        return list.Remove(element);
    }

    // Method to get the size of the list
    public static int GetSize(List<int> list)
    {
        return list.Count;
    }
}

// NUnit Test Cases for ListManager class
[TestFixture]
public class ListManagerTests
{
    private List<int> testList;

    [SetUp]
    public void Setup()
    {
        testList = new List<int>(); // Initialize a new list before each test
    }

    [Test]
    public void AddElement_AddsElementToList()
    {
        ListManager.AddElement(testList, 10);
        Assert.Contains(10, testList);
    }

    [Test]
    public void RemoveElement_RemovesExistingElement_ReturnsTrue()
    {
        testList.Add(20);
        bool result = ListManager.RemoveElement(testList, 20);
        Assert.IsTrue(result);
        Assert.IsFalse(testList.Contains(20));
    }

    [Test]
    public void RemoveElement_RemovesNonExistingElement_ReturnsFalse()
    {
        bool result = ListManager.RemoveElement(testList, 30);
        Assert.IsFalse(result);
    }

    [Test]
    public void GetSize_ReturnsCorrectSize()
    {
        ListManager.AddElement(testList, 5);
        ListManager.AddElement(testList, 15);
        Assert.AreEqual(2, ListManager.GetSize(testList));
    }
}
