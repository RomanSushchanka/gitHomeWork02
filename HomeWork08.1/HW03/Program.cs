using HW03;
internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            int[] numbers = { -1, 8, -12, 58, -68 };
            int max = numbers.MaxValue();
            Console.WriteLine(max);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}