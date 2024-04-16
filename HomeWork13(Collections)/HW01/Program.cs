using System;
using System.Collections.Generic;

class Program
{
    static IEnumerable<string> GetWordsGreaterThanFive(string[] words)
    {
        foreach (var word in words)
        {
            if (word.Length > 5)
            {
                yield return word;
            }
        }
    }

    static string[] GenerateRandomWords(int count)
    {
        Dictionary<int, string> wordDictionary = new Dictionary<int, string>()
        {
            { 1, "apple" },
            { 2, "banana" },
            { 3, "cherry" },
            { 4, "date" },
            { 5, "elderberry" },
            { 6, "fig" },
            { 7, "grape" },
            { 8, "honeydew" },
            { 9, "kiwi" },
            { 10, "lemon" }
        };

        Random random = new Random();
        List<string> randomWords = new List<string>();

        while (randomWords.Count < count)
        {
            int randomKey = random.Next(1, wordDictionary.Count + 1);
            string randomWord = wordDictionary[randomKey];

            if (!randomWords.Contains(randomWord))
            {
                randomWords.Add(randomWord);
            }
        }

        return randomWords.ToArray();
    }

    static void Main(string[] args)
    {
        string[] randomWords = GenerateRandomWords(3);

        Console.WriteLine("Слова длиной более 5 символов:");

        foreach (var word in GetWordsGreaterThanFive(randomWords))
        {
            Console.WriteLine(word);
        }
    }
}