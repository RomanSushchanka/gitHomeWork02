using System;
using System.IO;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        string file1Path = @"D:\\123\file1.txt";
        string file2Path = @"D:\\123\file2.txt";
        string file3Path = @"D:\\123\file3.txt";

        File.WriteAllText(file1Path, " Text from file 1 ");
        File.WriteAllText(file2Path, " Text from file 2 ");
        File.WriteAllText(file3Path, string.Empty);

        await Task.WhenAll(
            Task.Run(() => ReadAndWriteFile(file1Path, file3Path)),
            Task.Run(() => ReadAndWriteFile(file2Path, file3Path))
        );

        Console.WriteLine("Завершено!");
    }

    static async Task ReadAndWriteFile(string sourceFilePath, string destinationFilePath)
    {
        string content = await File.ReadAllTextAsync(sourceFilePath);
        lock (destinationFilePath)
        {
            File.AppendAllText(destinationFilePath, content);
        }
    }
}