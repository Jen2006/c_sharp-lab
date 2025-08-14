using System;

class Person
{
    private int age;
    public int Age
    {
        get
        {
            return age;
        }
        set
        { 
            
            age = value; 
        }
    }
}

class Program
{
    static void Main()
    {
        Person p = new Person();
        p.Age = 20;
        Console.WriteLine("person age: " + p.Age);
    }
}
