using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string filePath = "D:\\123\\File.txt";
        WriteTextToFile(filePath);
        ReadFileContents(filePath);
        Console.WriteLine("Операция завершена.");
    }

    static void WriteTextToFile(string filePath)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Привет"); 
                writer.WriteLine(); 
                writer.WriteLine("Привет"); 
            }

            Console.WriteLine("Текст успешно записан в файл.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при записи текста в файл: {ex.Message}");
        }
    }

    static void ReadFileContents(string filePath)
    {
        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при чтении файла: {ex.Message}");
        }
    }
}