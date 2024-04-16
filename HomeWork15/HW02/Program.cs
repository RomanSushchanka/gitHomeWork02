using System;

class Kindergarten
{
    public event EventHandler ChildGraduated;
    public void GraduateChild(string childName)
    {
        Console.WriteLine($"Ребенок {childName} окончил детский сад.");
        ChildGraduated?.Invoke(this, EventArgs.Empty);
    }
}

class School
{
    public void AcceptChild(object sender, EventArgs e)
    {
        Console.WriteLine("Ребенок принят в школу.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Kindergarten kindergarten = new Kindergarten();
        School school = new School();
        kindergarten.ChildGraduated += school.AcceptChild;
        kindergarten.GraduateChild("Гоша");
        Console.ReadKey();
    }
}