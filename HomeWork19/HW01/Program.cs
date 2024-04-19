using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        CancellationToken cancellationToken = cancellationTokenSource.Token;

        Action action = () =>
        {
            Console.WriteLine("Выполняется задача...");
            Thread.Sleep(2000);
            Console.WriteLine("Задача выполнена.");
        };

        RunActionAsync(action, cancellationToken);
        Thread.Sleep(1000);
        cancellationTokenSource.Cancel();
        Console.WriteLine("Нажмите любую клавишу для выхода...");
        Console.ReadKey();
    }

    static async void RunActionAsync(Action action, CancellationToken cancellationToken)
    {
        try
        {
            Task task = Task.Run(action, cancellationToken);
            await task;
            Console.WriteLine("Задача успешно выполнена.");
        }
        catch (TaskCanceledException)
        {
            Console.WriteLine("Задача отменена.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка выполнения задачи: " + ex.Message);
        }
    }
}