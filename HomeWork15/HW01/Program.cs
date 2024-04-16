using System;

class School
{
    public delegate void StudentAddedDelegate(string name, int age);
    public event StudentAddedDelegate StudentAdded;

    public void AddStudent(string name, int age)
    {
        Console.WriteLine($"Ученик {name} добавлен в школу.");
        StudentAdded?.Invoke(name, age);
    }
}

class Director
{
    public void GreetParents(string name, int age)
    {
        Console.WriteLine($"Добро пожаловать в школу, родители {name}! Ваш ребенок {age} лет.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        School school = new School();
        Director director = new Director();
        school.StudentAdded += director.GreetParents;
        school.AddStudent("Валера", 12);
        school.AddStudent("Коля", 11);
    }
}