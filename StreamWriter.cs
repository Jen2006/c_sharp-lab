using System;


class Program
{
    static void Main()
    {
        string path= @"C:\Users\Student 1\Desktop\jen c#\source.txt";

        using (StreamWriter w = new StreamWriter(path))
        {

            w.WriteLine("Well.....");
            w.WriteLine("I do not know what is going on");
            
        }

        Console.WriteLine("File written successfully.");    
    }
}
