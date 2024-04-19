using System;
using System.IO;

public class DirectoryHelper
{
    public int GetFileCount(string path)
    {
        try
        {
            string[] files = Directory.GetFiles(path);
            return files.Length;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            return -1;
        }
    }

    public FileInfo[] GetFiles(string path)
    {
        try
        {
            DirectoryInfo directory = new DirectoryInfo(path);
            return directory.GetFiles();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            return null;
        }
    }

    public int GetFileCountByExtension(string path, string extension)
    {
        try
        {
            string[] files = Directory.GetFiles(path, $"*.{extension}");
            return files.Length;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            return -1;
        }
    }

    public FileInfo[] GetFilesByExtension(string path, string extension)
    {
        try
        {
            DirectoryInfo directory = new DirectoryInfo(path);
            return directory.GetFiles($"*.{extension}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            return null;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        string directoryPath = "ПутьКФайлам";
        string fileExtension = "pdf";

        DirectoryHelper directoryHelper = new DirectoryHelper();

        // Получить количество файлов в каталоге
        int fileCount = directoryHelper.GetFileCount(directoryPath);
        Console.WriteLine($"File count: {fileCount}");

        // Получить информацию о файлах в каталоге
        FileInfo[] files = directoryHelper.GetFiles(directoryPath);
        Console.WriteLine("Files:");
        foreach (FileInfo file in files)
        {
            Console.WriteLine(file.Name);
        }

        // Получить количество файлов с указанным расширением в каталоге
        int fileCountByExtension = directoryHelper.GetFileCountByExtension(directoryPath, fileExtension);
        Console.WriteLine($"File count with extension '{fileExtension}': {fileCountByExtension}");

        // Получить информацию о файлах с указанным расширением в каталоге
        FileInfo[] filesByExtension = directoryHelper.GetFilesByExtension(directoryPath, fileExtension);
        Console.WriteLine($"Files with extension '{fileExtension}':");
        foreach (FileInfo file in filesByExtension)
        {
            Console.WriteLine(file.Name);
        }
    }
}