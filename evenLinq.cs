using System;
using System.Collections.Generic;

class program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        var evennumbers = from n in numbers
                          where n % 2 == 0
                          select n;

        Console.WriteLine("Even Numbers: ");
        foreach(var num in evennumbers)
        {
            Console.WriteLine(num);
        }
    }
}
