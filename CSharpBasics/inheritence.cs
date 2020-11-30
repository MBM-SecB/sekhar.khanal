using System;
public abstract class Shape
{
    public abstract double GetArea();

    public abstract double GetCircumference();
    public virtual void PrintResults()
    {
        Console.WriteLine("Printing result for same shape ...");
    }

}
interface ComputeDiagnol
{
    public double GetDiagonal();
}

public class Square : Rectangle
{

    public Square(double side) : base(side, side)
    {

    }


}

public class Rectangle : Shape
{
    public double Length { get; set; }
    public double Breadth { get; set; }

    public Rectangle(double length, double breadth)
    {
        Length = length;
        Breadth = breadth;
    }

    public override double GetArea() => Length * Breadth;

    public override double GetCircumference() => 2 * (Length + Breadth);

    public override void PrintResults()
    {
        Console.WriteLine($"Printing result for rectangle [{Length}x{Breadth}]:");
        Console.WriteLine($"Area: {this.GetArea()}");
        Console.WriteLine($"Area: {this.GetCircumference()}");
    }

}

public class Circle : Shape
{

    public double Radius { get; set; }
    public override double GetArea() => Math.PI * Radius * Radius;

    public override double GetCircumference() => 2 * Math.PI * Radius;


}
class A
{ }
class B : A
{ }

class C : B
{ }

class D : A, IA, IB
{ }

interface IA
{ }
interface IB
{ }