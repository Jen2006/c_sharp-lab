using System;

class Program
{
    static void Main()
    {
        string sentence = "My name is Archit Patel";
        string[] words = sentence.Split(' ');
        Array.Reverse(words);
        string reversed = string.Join(" ", words);
        Console.WriteLine(reversed);
    }
}
