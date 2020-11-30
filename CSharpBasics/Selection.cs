using System;


class SelectionStatement
{

    static void Main2()
    {
        SelectionStatement s = new SelectionStatement();
        // s.CheckNumber();
        s.CheckNumber();
    }
    void CheckNumber(){
        Console.Write("Enter number: ");
        string input = Console.ReadLine();

        int number = int.Parse(input);

        if((number % 2) ==0)
        {
            Console.WriteLine("Your entered number is Even");
        }
        else
        {
            Console.WriteLine("Your entered number is Odd");
        }
    }

    void LearnSwitchStatements()
    {
        Console.Write("Enter your hobby: ");
        string input = Console.ReadLine();

        switch(input)
        {
            case "books":
            Console.Write("Books");
            break;

            case "football":
            Console.Write("football");
            break;

            case "swimming":
            Console.Write("swimming");
            break;

            case "puzzle":
            Console.Write("puzzle");
            break;

            case "sports":
            Console.Write("sports");
            break;

            default:
            Console.Write("You poor man without a hobby");
            break;

        }

    }
}