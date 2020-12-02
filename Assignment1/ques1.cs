using System;

class Ques1
{
    static void Main()
    {
        Ques1 s=new Ques1();
        Console.WriteLine("enter first number :");
        int num1=int.Parse(Console.ReadLine());

        Console.WriteLine("enter second number :");
        int num2=int.Parse(Console.ReadLine());

        bool result = s.Sum(num1,num2);
        Console.WriteLine(result);
    }

    bool Sum(int firstNum, int secondNum)
    {
        int sum=firstNum+secondNum;
        if (sum>500)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}