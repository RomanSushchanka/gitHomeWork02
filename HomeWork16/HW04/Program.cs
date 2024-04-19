using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    public static class EnumerableExtensions
    {
        public static T Median<T>(this IEnumerable<T> source)
        {
            if (source == null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            var sortedList = source.OrderBy(x => x).ToList();
            int count = sortedList.Count;

            if (count == 0)
            {
                throw new InvalidOperationException("Sequence contains no elements.");
            }

            return sortedList[count / 2];
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 10, 40, 50, 99, 7 };

            int median = numbers.Median();
            Console.WriteLine($"Median: {median}");
        }
    }
}