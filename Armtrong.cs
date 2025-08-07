// See https://aka.ms/new-console-template for more information
using System;

class Armstong
{
    static void Main()
    {
        Console.WriteLine("Enter a number");
        int a = Convert.ToInt32(Console.ReadLine());

        int sum= 0, temp = a;

        while(temp>0)
        {
            int d= temp % 10;
            sum += d * d * d;
            temp /= 10;
        }
        if(sum==a)
        {
            Console.WriteLine("Armstrong");
        }
        else
        {
            Console.WriteLine("Not Armstrong");
        }

    }

}
