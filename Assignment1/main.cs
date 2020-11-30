using System;
class main{


static void Main()
{
    String a;
    Console.Write("QESTIONS: \n");
    Console.WriteLine("1. Given two numbers, write C# method that returns true if sum of both numbers is greater than 500. Otherwise returns false.\n");
    Console.WriteLine("2.Create a function that takes the number of wins, draws and losses, and calculates the number of points a football team has obtained so far. Rule - wins get 5 points, draws get 2 point and losses get 0 points.\n");
    Console.WriteLine("3.Creates a function that takes a two word string separated by space and returns the concatenated first characters of both the words. E.g. GetInitials(\"Bishnu Rawal\") => \"BR\" GetInitials(\"Alex Wales\") => \"AW\" ");
    Console.Write("\nEnter Question number: ");

    a = Console.ReadLine();
    Ques1 x  = new Ques1();
    Ques2 y  = new Ques2();
    Ques3 z = new Ques3();

    switch(a)
    {
        case "1":
        x.Sum();
        break;

        case "2":
        y.number_of_points();
        break;

        case "3":
        z.GetInitials();
        break;

        default:
        Console.WriteLine("Enter valid question number");
        break;


        
    }

}

};