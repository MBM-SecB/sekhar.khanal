using System.IO;
using System;

public class FileIO
{
    public void LearnFileReading()
    {
        string filePath = @"E:\ajit_pandey\README.md";
        string fileInProject = "generics.cs";

        if (File.Exists(filePath))
        {
            var fileContent = File.ReadAllText(fileInProject);
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(fileContent);
        }
    }
    public void LearnFileWriting()
    {
        string filePath = "Abc.txt";
        File.WriteAllText(filePath,"Hello World!");

    }

    public void LearnFileInfo()
    {
        string filePath = "Abc.txt";
        FileInfo fileInfo  = new FileInfo(filePath);
        var fileSize =fileInfo.Length;
        var createdDate = fileInfo.CreationTime;

        Console.WriteLine(filePath);
        Console.WriteLine("Size: "+ fileSize  + " bytes");
        Console.WriteLine("Created Date: "+createdDate);
    }
    public void LearnDirectory()
    {
        string folderPath = "ABC";
        Directory.CreateDirectory(folderPath);
        Console.WriteLine("Do you want to delete MBM folder?");
        string confirm = Console.ReadLine();
        if(confirm == "Y")
        {
            Directory.Delete(folderPath);
        }

        // HW: Create a folder "Nepal", within that folder create 10 sub folders.
        // Every subfolder should contain a file Test.txt with subfolder name as content.
    }
}