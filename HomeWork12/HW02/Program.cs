using System;
using System.Collections.Generic;

public enum Gender
{
    Female,
    Male
}

public class Person : IComparable<Person>
{
    public int Age { get; set; }
    public Gender Gender { get; set; }

    public int CompareTo(Person other)
    {
        if (this.Gender != other.Gender)
        {
            return this.Gender.CompareTo(other.Gender);
        }
        else
        {
            return this.Age.CompareTo(other.Age);
        }
    }
}

public class PersonComparer : IComparer<Person>
{
    public int Compare(Person x, Person y)
    {
        if (x.Gender != y.Gender)
        {
            return x.Gender.CompareTo(y.Gender);
        }
        else
        {
            return x.Age.CompareTo(y.Age);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Person> listOfPerson = new List<Person>
        {
            new Person { Age = 25, Gender = Gender.Female },
            new Person { Age = 30, Gender = Gender.Male },
            new Person { Age = 20, Gender = Gender.Female },
            new Person { Age = 35, Gender = Gender.Male },
            new Person { Age = 22, Gender = Gender.Female },
            new Person { Age = 28, Gender = Gender.Male },
            new Person { Age = 27, Gender = Gender.Female },
            new Person { Age = 32, Gender = Gender.Male },
            new Person { Age = 23, Gender = Gender.Female },
            new Person { Age = 31, Gender = Gender.Male }
        };

        listOfPerson.Sort();

        Console.WriteLine("Сортировка с использованием IComparable<Person>:");
        foreach (var person in listOfPerson)
        {
            Console.WriteLine($"Возраст: {person.Age}, Пол: {person.Gender}");
        }

        Person[] array = listOfPerson.ToArray();
        Array.Sort(array, new PersonComparer());

        Console.WriteLine("\nСортировка с использованием PersonComparer:");
        foreach (var person in array)
        {
            Console.WriteLine($"Возраст: {person.Age}, Пол: {person.Gender}");
        }
    }
}