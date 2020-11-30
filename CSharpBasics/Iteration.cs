using System;


class IterationStatement
{
    static void Main6()
    {
        IterationStatement iterationStatement = new IterationStatement();
        iterationStatement.LearnWhileLoops();

        AccessModifier accessModifier  = new AccessModifier();
        accessModifier.DoSomething();

        Person person = new Person();
        person.age = 34;
    }
    void LearnForLoops()
    {
        for(int i=0;i<20;i++)
        {
        Console.WriteLine("Hello There");
        }

        byte[] personAges = {23,46,86,73};

        foreach(byte age in personAges)
        {
            if(age % 2 ==0)
            {
                Console.WriteLine(age + " is even");
            }
            else
            {
                Console.WriteLine(age + " is odd");
            }
        }


    }

    void LearnWhileLoops()
    {
        char confirm = 'Y';
        while(confirm == 'Y')
        {
            Console.WriteLine("Infinite Loop");
            Console.Write("Enter any Y to continue: ");
            confirm = Console.ReadKey().KeyChar;
        }
        do
        {
            Console.WriteLine("I am inside while loop");
            Console.Write("Enter any Y to continue: ");
            confirm = Console.ReadKey().KeyChar;
        }
        while(confirm == 'Y');
        
    }
}