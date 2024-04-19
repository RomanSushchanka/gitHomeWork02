using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string parentDirectory = "D:\\123";

        // Создание дочерних директорий
        CreateChildDirectories(parentDirectory);

        // Удаление дочерних директорий
        DeleteChildDirectories(parentDirectory);

        Console.WriteLine("Дочерние директории удалены.");
    }

    static void CreateChildDirectories(string parentDirectory)
    {
        try
        {
            for (int i = 0; i < 20; i++)
            {
                string directoryName = $"MyTestFolder{i}";
                string directoryPath = Path.Combine(parentDirectory, directoryName);
                Directory.CreateDirectory(directoryPath);
            }

            Console.WriteLine("Дочерние директории созданы.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при создании дочерних директорий: {ex.Message}");
        }
    }

    static void DeleteChildDirectories(string parentDirectory)
    {
        try
        {
            string[] childDirectories = Directory.GetDirectories(parentDirectory);

            foreach (string childDirectory in childDirectories)
            {
                Directory.Delete(childDirectory, true);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при удалении дочерних директорий: {ex.Message}");
        }
    }
}