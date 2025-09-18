using System;

class Exception
{
    static void Main()
{


      try
        {
            Console.WriteLine("Enter first number");
            int a=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number");   
            int b=Convert.ToInt32(Console.ReadLine());

            int c =a/ b;
            Console.WriteLine("Result: " + c);
       }

        catch(DivideByZeroException)
       {
            Console.WriteLine("Error:Cannot divide by zero!");
       }
       catch(FormatException)
       {
           Console.WriteLine("Error:Please enter valid numbers only.");
       }

        finally
        {
 
               Console.WriteLine("Thank you for using the program.");
        } 
         
    }
}    
     
