using System;
using System.IO;  // Don't forget this for File class

class Program
{
    static void Main()
    {
        // Use verbatim string literal, with single backslashes
        string source = @"C:\Users\Student 1\Desktop\jen c#\source.txt";
        string destination = @"C:\Users\Student 1\Desktop\jen c#\destination.txt";

        // Read all text from the source file
        string content = File.ReadAllText(source);

        // Write the content to the destination file
        File.WriteAllText(destination, content);

        Console.WriteLine("File contents copied successfully!");
    }
}
