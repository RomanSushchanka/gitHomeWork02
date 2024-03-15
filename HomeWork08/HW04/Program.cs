using HW04;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            Bag bag = new Bag();
            bag.isOpen = false;
            Console.WriteLine("Что складываем в сумку");
            string obj = Console.ReadLine();
            if (bag.AddValueToArray(obj))
            {
                Console.WriteLine($"В сумку добавлен {obj}");
            }

            bag.isOpen = true;
            Console.WriteLine($"Из сумки вытащили {bag.TakeOutValueToArray(0)}");
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        
    }
}