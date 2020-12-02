using System;

class Ques3
{
    static void Main3()
    {
        Ques3 check = new Ques3();
        Console.WriteLine("Enter your name : ");
        string name = Console.ReadLine();

        string result = check.GetInitials(name);
        Console.WriteLine(result);

    }

    string GetInitials(string name)
    {
        string a="";
        int b=name.Length;
        a+=name[0];

        for(int i=0;i<b;i++)
        {
            if(name[i]==' ')
            {
                a+=name[++i];
            }
        }
        return a;
    }
}