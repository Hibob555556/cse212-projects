using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add multiple items with different priorities
    // Expected Result: Then dequeue all items
    // Defect(s) Found: Assert.IsTrue failed. Expected and actual priorities did not match
    // RESULT AFTER IMPLEMENTATION: Passed - Queue correctly returns item with highest priority.
    public void TestPriorityQueue_1()
    {
        // Create a priority queue and enqueue items of different priorities
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("item1", 5);
        priorityQueue.Enqueue("item2", 3);
        priorityQueue.Enqueue("item3", 1);

        // create lists to store expected and actual priorities
        List<string> returnedPriorities = [];
        List<string> expectedPriorities = ["item1", "item2", "item3"];
        for (int i = 0; i < 3; i++)
        {
            // get next item in the priority list
            var item = priorityQueue.Dequeue();
            returnedPriorities.Add(item);
        }

        Assert.IsTrue(expectedPriorities.SequenceEqual(returnedPriorities));
    }

    [TestMethod]
    // Scenario: Provide multiple items of the same priority
    // Expected Result: the items will be returned fifo
    // Defect(s) Found: Assert.IsTrue failed. Repeatedly returns the same item from the queue
    public void TestPriorityQueue_2()
    {
        // Create a priority queue and enqueue items of different priorities
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("first_out", 5);
        priorityQueue.Enqueue("second_out", 5);
        priorityQueue.Enqueue("third_out", 5);

        // create lists to store expected and actual priorities
        List<string> returnedPriorities = [];
        List<string> expectedPriorities = ["first_out", "second_out", "third_out"];
        for (int i = 0; i < 3; i++)
        {
            // get next item in the priority list
            var item = priorityQueue.Dequeue();
            returnedPriorities.Add(item);
            Console.WriteLine(item);
        }

        Assert.IsTrue(expectedPriorities.SequenceEqual(returnedPriorities));
    }

    [TestMethod]
    // Scenario: Dequeue an item from an empty queue
    // Expected Result: an invalid operation exception will be thrown with message "The queue is empty."
    // Defect(s) Found: None
    public void TestPriorityQueue_3()
    {
        // Create a priority queue and enqueue items of different priorities
        var priorityQueue = new PriorityQueue();

        // attempt to remove an item from the empty queue
        try
        {
            priorityQueue.Dequeue();

            // fail because it did not error 
            Assert.Fail();
        }
        catch (InvalidOperationException ioe)
        {
            // pass if error message is correct
            Assert.IsTrue(ioe.Message == "The queue is empty.");
        }
    }
}