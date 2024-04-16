using System;
using System.Collections.Generic;

class Collection<T> where T : IComparable<T>
{
    private List<T> items = new List<T>();

    public void Add(T item)
    {
        items.Add(item);
        items.Sort();
    }

    public void Display()
    {
        foreach (var item in items)
        {
            Console.WriteLine(item.ToString());
        }

        Console.WriteLine();
    }
}

class MyClass : IComparable<MyClass>
{
    public int IdNumber { get; set; }

    public int CompareTo(MyClass other)
    {
        return IdNumber.CompareTo(other.IdNumber);
    }

    public override string ToString()
    {
        return $"IdNumber: {IdNumber}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Collection<MyClass> collection = new Collection<MyClass>();

        collection.Add(new MyClass { IdNumber = 3 });
        collection.Add(new MyClass { IdNumber = 1 });
        collection.Add(new MyClass { IdNumber = 2 });

        collection.Display();

        collection.Add(new MyClass { IdNumber = 4 });

        collection.Display();
    }
}