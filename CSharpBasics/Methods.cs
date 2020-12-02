using System;

public class MethodTeacher
{
    
    //simple method: takes 2 arguments, and returns a value
    public int Multiply(int firstNum, int secondNum)
    {
        int result=firstNum*secondNum;
        return result;
    }

    public void Multiply<T>(T firstNum, T secondNum)
    {
        
    }

    // Variable number of arguments 

    public int Multiply(params int[] numbers)
    {
        int product=1;
        foreach(int num in numbers)
        {
            product=product*num;
        }
        return product;
    }

    //Named arguments
    internal void PrintCostumerDetails(string name, byte age,string address,DateTime dob)
    {
        //using string interpolation here: $"{}"
        //if hamlai k aauxa tha xaina vane jaile $ use garne
        Console.Write($"costumer details: {name},{age},{address},{dob}");
    }

    //Returning multiple value
    // Question: Method which returns max and min valur of supplied numbers


    internal (int, int) FindMinMax(params int[] numbers)
    {
        int min=numbers[0];
        int max=numbers[0];

        foreach(int num in numbers)
        {
            if(num<min)
                min=num;
            
            if(num>max)
                max=num;
        }
        return (min,max);
    }
}

public class MethodTester
{
    void TestMethods()
    {
        MethodTeacher methodTeacher = new MethodTeacher();
        int product = methodTeacher.Multiply(2345,34562);
        

        product=methodTeacher.Multiply(344,523,5467);
        product=methodTeacher.Multiply(344,523,5467,7657,675);

        methodTeacher.Multiply<decimal>(234.54m,5424.543654m);
        
        methodTeacher.PrintCostumerDetails(dob:DateTime.Now, name:"Sabita", age:21, address:"Jhapa");

        (int min,int max) result = methodTeacher.FindMinMax(2,3,4,5,6,7,8,9,45,56,98);

        Console.WriteLine($"Minimum: {result.min}, Maximum:{result.max}");

    }
}