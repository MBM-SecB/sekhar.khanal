using System;
using System.IO;

public class fileio
{
    public void Assign()
    {
        string rootFolderName = "Nepal";
        Directory.CreateDirectory(rootFolderName);
        string[] subFoldersName = {"Kathmandu","bhaktapur","lalitpur","butwal","jumla","humla","surkhet","arghakanchi","manang","mustang"};
        foreach(string sub in subFoldersName)
        {
            string subFolderNamePath = rootFolderName + "/" + sub;
            Directory.CreateDirectory(subFolderNamePath);
            string filePath = subFolderNamePath + "/" + "Test.txt";
            File.WriteAllText(filePath,sub);
        }
    }
}