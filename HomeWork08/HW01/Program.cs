using HW01;

internal class Program
{
    private static void Main(string[] args)
    {

        Item i = new Item();
        Console.WriteLine(i.GetName());

        i.SetName("Valera");
        Console.WriteLine(i.GetName());
    }
}