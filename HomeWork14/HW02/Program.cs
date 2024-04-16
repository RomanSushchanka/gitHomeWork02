using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Введите первое число от 0 до 255:");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число от 0 до 255:");
            int number2 = int.Parse(Console.ReadLine());

            int result = DivideNumbers(number1, number2);
            Console.WriteLine($"Результат деления: {result}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка формата ввода числа. Введите целое число от 0 до 255.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Введено число, выходящее за пределы допустимого диапазона [0-255].");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Деление на ноль невозможно.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
    }

    static int DivideNumbers(int number1, int number2)
    {
        if (number2 == 0)
        {
            throw new DivideByZeroException();
        }

        return number1 / number2;
    }
}