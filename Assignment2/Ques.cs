// HW: Create a folder "Nepal", with in that create 10 sub folders. 
// Every subfolders should contain a file Test.txt with subfolder name as a content. 

using System;
using System.IO;

class IOAssignment
{
    void CreateDirectory()
    {
        string filePath = "Nepal";
        Directory.CreateDirectory(filePath);

        string subDirectory = "subfolder";

        for (int i = 1; i <= 10; i++)
        {
            string subFilePath=$"{filePath}/{subDirectory+i}";
            Directory.CreateDirectory(subFilePath);
            string fileName=$"{subFilePath}/text.txt";
            File.WriteAllText(fileName, "hello");
        }
        Console.WriteLine("Directory is created successfully.....");
    }

    static void Main()
    {
        IOAssignment nepal = new IOAssignment();
        nepal.CreateDirectory();


    }
}