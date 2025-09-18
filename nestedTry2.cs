using System;

class Prog
{

    static void Main()
    {


        try
        {
            Console.WriteLine("Outer try");

            try
            {
                Console.WriteLine("Inner try");
                int number = int.Parse("abc");  // This will cause FormatException
            }
            catch (FormatException)
            {
                Console.WriteLine("Caught FormatException in inner catch");
            }

            int[] arr = new int[2];
            Console.WriteLine(arr[5]);  // This will cause IndexOutOfRangeException
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Caught IndexOutOfRangeException in outer catch");
        }

    }
}
