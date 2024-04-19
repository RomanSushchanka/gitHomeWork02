using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        await RunTaskWithAwaiter(2000);
        RunTaskWithContinueWith(3000);
        Console.ReadLine();
    }

    static async Task RunTaskWithAwaiter(int time)
    {
        await Task.Delay(time).ConfigureAwait(false);
        Console.WriteLine("Hello from callback (awaiter)");
    }

    static void RunTaskWithContinueWith(int time)
    {
        Task.Delay(time).ContinueWith(task =>
        {
            Console.WriteLine("Hello from callback (ContinueWith)");
        });
    }
}