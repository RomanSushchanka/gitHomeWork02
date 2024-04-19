using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> A = new List<string> { "Hello", "here", "we", "are" };
        List<char> result = GetInitialCharacters(A);

        Console.WriteLine("Результат:");
        foreach (char character in result)
        {
            Console.WriteLine(character);
        }
    }

    static List<char> GetInitialCharacters(List<string> strings)
    {
        List<char> characters = new List<char>();

        for (int i = strings.Count - 1; i >= 0; i--)
        {
            string str = strings[i];
            if (!string.IsNullOrEmpty(str))
            {
                characters.Add(str[0]);
            }
        }

        return characters;
    }
}