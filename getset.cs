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

    public void display()
    {
        if(age >=18)
        {
            Console.WriteLine("Major");
        }
        else
        {
            Console.WriteLine("Minor");
        }


    }
}

class Program
{
    static void Main()
    {
        Person p = new Person();
        Console.WriteLine("Enter an age");
        int a=Convert.ToInt32(Console.ReadLine());  

        p.Age = a;
        p.display();
       
    }
}
