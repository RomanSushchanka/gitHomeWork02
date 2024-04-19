using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Thread numbersThread = new Thread(NumbersTask);
        numbersThread.Start();

        Thread lettersThread = new Thread(LettersTask);
        lettersThread.Start();

        numbersThread.Join();
        lettersThread.Join();

        Console.WriteLine("Готово");
        Console.ReadLine();
    }

    static void NumbersTask()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }
    }

    static void LettersTask()
    {
        for (char c = 'A'; c <= 'J'; c++)
        {
            Console.WriteLine(c);
        }
    }
}