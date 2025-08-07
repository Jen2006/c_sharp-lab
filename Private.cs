// See https://aka.ms/new-console-template for more information
using System;

class Age
{
    private int age;

   /*  public void Read()
    {
        Console.WriteLine("Enter the age");
        age=Convert.ToInt32(Console.ReadLine());
    } */


    public void display(int a)
    {
        age = a;
        Console.WriteLine("Age:" + age);
    }

}
class Prgm
{
    static void Main()
    {
        Age a = new Age();
    
        //a.Read();

        a.display(34);
    }
}