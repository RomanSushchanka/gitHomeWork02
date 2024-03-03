using HW01;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] array = { 1, 2, 3, 4, 5 };

        ArrayWorker arrayWorker = new ArrayWorker();
        int[] invertedArray = arrayWorker.InvertArray(array);



        Console.WriteLine("Array: ");
        foreach (int element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();


        Console.WriteLine("Inverted array: ");
        foreach (int element in invertedArray)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}
