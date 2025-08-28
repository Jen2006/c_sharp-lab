using System;
using System.Runtime.CompilerServices;

class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Drawing a shape");
    }

    public virtual void Erase()
    {

              Console.WriteLine("Erasing a shape");
    }
}

class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle");
    }
    public override void Erase()
    {
        Console.WriteLine("Erasing a circle");
    }
}

class Square : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a square");
    }
    public override void Erase()
    {
        Console.WriteLine("Erasing a square");
    }
}   
class Triangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a triangle");
    }
    public override void Erase()
    {
        Console.WriteLine("Erasing a triangle");
    }
}

class Program
{
    static void Main(string[] args)
    {   //Alternative way 
        /*  Circle c = new Circle();
           c.Draw();
           c.Erase();

          Triangle t = new Triangle();
           t.Draw();
           t.Erase();

          Square s = new Square();     
           s.Draw();
           s.Erase();  */

        Shape s;
        s=new Circle();
        s.Draw();
        s.Erase();

        s = new Triangle();
        s.Draw();
        s.Erase();

        s = new Square();   
        s.Draw();
        s.Erase();

    }
}
