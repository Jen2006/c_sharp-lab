// See https://aka.ms/new-console-template for more information
using System;

class Animal
{
    protected void sound()
    {
        Console.WriteLine("Animal makes souund");
    }
}

class Dog : Animal
{
    public void bark()
    {
        //sound();
        Console.WriteLine("Dog barks");

    }


    static void Main()
    {
        Dog d = new Dog();
        d.sound();
        d.bark();
    }
}