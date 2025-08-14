using System;

public abstract class Shape
{
  public  abstract void  CalculateArea();
}

class Circle : Shape
{
    private int r;

    public void Read(int a)
    {
        r = a;
    }

    public override void CalculateArea()
    {
        float area = 3.14f * r * r;
        Console.WriteLine("Area of the circle: " + area);
    }

}
class Program
{
    static void Main()
    {
        Circle c=new Circle();
        Console.WriteLine("Enter the radius");
        int a=Convert.ToInt32(Console.ReadLine());
        c.Read(a);
        c.CalculateArea();
    }
}
