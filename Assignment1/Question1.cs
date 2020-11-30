using System;

public class Ques1
{
    // static void Main1()
    // {
    //     Ques1 s=new Ques1();
    //     s.Sum();
    // }
    public bool Sum()
    {
        Console.Write("Enter first number: ");
        int firstNum = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number:  ");
        int secondNum = Convert.ToInt32(Console.ReadLine());


        int sum=firstNum+secondNum;
        var d =  sum>500? true:false;
        return d;
        
    }
}