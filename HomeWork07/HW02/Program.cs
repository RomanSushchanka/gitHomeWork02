using HW02;

internal class Program
{
    private static void Main(string[] args)
    {
        double r = 5;
        double h = 10;

        Cone cone = new Cone(r, h);

        double baseArea = cone.CalcBaseArea();
        double totalArea = cone.CalcTotalArea();

        Console.WriteLine("Base Area: " + baseArea);
        Console.WriteLine("Total Area: " + totalArea);
    }
}