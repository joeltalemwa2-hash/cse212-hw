using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add items with different priorities into the queue
    // Expected Result:The item with the highest priority should be removed first.
    // Defect(s) Found: The queue did not always remove the highest priority item correctly. 
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
         priorityQueue.Enqueue("Low", 1);
        priorityQueue.Enqueue("Medium", 5);
        priorityQueue.Enqueue("High", 10);

        var result = priorityQueue.Dequeue();

        Assert.AreEqual("High", result);
    }

    [TestMethod]
    // Scenario: Add multiple items with the same priority.
    // Expected Result: The first inserted item should be removed first (FIFO behavior).
    // Defect(s) Found: The queue incorrectly removed the most recent item instead of
    // preserving FIFO order for equal priorities. 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("First", 5);
        priorityQueue.Enqueue("Second", 5);

        var result = priorityQueue.Dequeue();

        Assert.AreEqual("First", result);
    }

    // Add more test cases as needed below.
    
    [TestMethod]
    // Scenario: Attempt to dequeue from an empty queue.
    // Expected Result: InvalidOperationException should be thrown with correct message.
    // Defect(s) Found: The queue did not always throw the required exception.
    public void TestPriorityQueue_Empty()
    {
        var priorityQueue = new PriorityQueue();

        Exception ex = Assert.ThrowsException<InvalidOperationException>(() =>
        {
            priorityQueue.Dequeue();
        });

        Assert.AreEqual("The queue is empty.", ex.Message);
    }
}