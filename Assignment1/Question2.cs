using System;
public class Ques2{
// static void Main2()
// {
//     Ques2 ques=new Ques2();
//     ques.number_of_points();
// }
public void number_of_points()
{
    Console.Write("Enter number of wins: ");
    int win = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter number of draws: ");
    int draw = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter number of losses: ");
    int loss = Convert.ToInt32(Console.ReadLine());
    
    int points=win*5+draw*2;
    Console.WriteLine("Total Points: " + points);
}
}