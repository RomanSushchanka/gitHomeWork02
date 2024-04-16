using System;

class EmptyStringException : Exception
{
    public EmptyStringException() : base("Передана пустая строка.") { }
}

class MyClass
{
    public void ProcessString(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            throw new EmptyStringException();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        try
        {
            MyClass myObject = new MyClass();
            myObject.ProcessString("");
        }
        catch (EmptyStringException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
    }
}