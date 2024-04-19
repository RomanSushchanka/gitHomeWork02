using System;
using System.Threading;

class Program
{
    static int counter = 0;
    static Mutex mutex = new Mutex();

    static void Main(string[] args)
    {
        Thread[] threads = new Thread[5];
        for (int i = 0; i < threads.Length; i++)
        {
            threads[i] = new Thread(IncrementCounter);
            threads[i].Start();
        }

        for (int i = 0; i < threads.Length; i++)
        {
            threads[i].Join();
        }

        Console.WriteLine("Результат: " + counter);
    }

    static void IncrementCounter()
    {
        for (int i = 0; i < 10000; i++)
        {
            mutex.WaitOne();
            counter++;
            mutex.ReleaseMutex();
        }
    }
}