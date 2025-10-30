using System;
using System.Linq;

public class Program 
{
    
    public static void Main(string[] args)
    {
        int[] array = { 11,67,24,8,24,78,987,781,223 };

        var result = from n in array
                     where n % 2 ==0
                     select n;

        foreach ( var k in result )
        {
                       Console.WriteLine(k);
        }
    }
}
public class Program 
{
    
    public static void Main(string[] args)
    {
        int[] array = { 11,67,24,8,24,78,987,781,223 };

        var result = from n in array
                     where n % 2 ==0
                     select n;

        foreach ( var k in result )
        {
                       Console.WriteLine(k);
        }
    }
}
