using System;

class lucky
{
    static void Main()
    {
        for (int i=1; i<=100;i++)
        {

            if (i %4 ==0 && i%6==0)
            {
                Console.WriteLine("The lucky ticket no:" + i);
            }
        }
    }
}
