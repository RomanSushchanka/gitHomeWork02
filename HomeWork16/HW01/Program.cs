using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> sequence = new List<int> { -10, 22, 13, 43, -5, -12, 100 };

        List<int> extractedNumbers = sequence.Where(x => x < 0 && x % 2 == 0).ToList();
        extractedNumbers.Reverse();

        Console.WriteLine("Извлеченные числа:");

        foreach (int number in extractedNumbers)
        {
            Console.WriteLine(number);
        }
    }
}