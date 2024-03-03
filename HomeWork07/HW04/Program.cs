internal class Program
{
    private static void Main(string[] args)
    {
        var queue = new Queue<int>();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        queue.Enqueue(4);

        Console.WriteLine($"Should print out 1: {queue.Peek()}");

        queue.Dequeue();

        Console.WriteLine($"Should print out 2: {queue.Peek()}");

        Console.WriteLine($"Iterate over the queue.");
        foreach (var cur in queue)
        {
            Console.WriteLine(cur);
        }
    }
}