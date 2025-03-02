using System;
using System.Threading;
using NUnit.Framework;

// Utility class with a long-running method
public class PerformanceUtils
{
    // Simulates a long-running task (sleeps for 3 seconds)
    public static string LongRunningTask()
    {
        Thread.Sleep(3000); // Simulating delay
        return "Task Completed";
    }
}

// NUnit Test Cases for PerformanceUtils class
[TestFixture]
public class PerformanceUtilsTests
{
    // This test will fail if it takes longer than 2 seconds
    [Test, Timeout(2000)] 
    public void LongRunningTask_WhenExceedsTimeout_FailsTest()
    {
        string result = PerformanceUtils.LongRunningTask();
        Assert.AreEqual("Task Completed", result);
    }
}
