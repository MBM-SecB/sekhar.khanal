using System;

class Ques2{
static void Main2()
{
    Ques2 ques=new Ques2();
    
    Console.WriteLine("enter number of wins :");
    int wins=int.Parse(Console.ReadLine());

    Console.WriteLine("enter number of draw :");
    int draws=int.Parse(Console.ReadLine());

    Console.WriteLine("enter number of losses :");
    int losses=int.Parse(Console.ReadLine());

    ques.NumberOfPoints(wins,draws,losses);
}

void NumberOfPoints(int win,int draw,int loss)
{
    int wins=win*5;
    int draws=draw*2;
    int losses=loss*0;

    int points=wins+draws+losses;
    Console.WriteLine(points);
}
}