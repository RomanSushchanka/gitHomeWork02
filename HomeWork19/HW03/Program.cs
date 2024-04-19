using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

public class Pizzeria
{
    private SemaphoreSlim _semaphore;
    public Pizzeria(int numberOfWorkers)
    {
        _semaphore = new SemaphoreSlim(numberOfWorkers);
    }
    public async Task CookPizzaAsync(string pizzaName)
    {
        await _semaphore.WaitAsync();

        try
        {
            Console.WriteLine($"Приготовление пиццы {pizzaName}...");
            await Task.Delay(3000);
            Console.WriteLine($"Пицца {pizzaName} готова!");
        }
        finally
        {
            _semaphore.Release();
        }
    }
}

public class Program
{
    public static async Task Main(string[] args)
    {
        Pizzeria pizzeria = new Pizzeria(2);
        List<Task> tasks = new List<Task>();

        for (int i = 0; i < 5; i++)
        {
            tasks.Add(pizzeria.CookPizzaAsync($"Пицца {i + 1}"));
        }

        await Task.WhenAll(tasks);
        Console.WriteLine("Все пиццы готовы!");
        Console.ReadLine();
    }
}