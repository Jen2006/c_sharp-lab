using System;

class Course
{
  protected void  ShowDetails()
    {
        Console.WriteLine("Course Name:BCA");
        Console.WriteLine("Course Duration:3 years");
        Console.WriteLine("Course Fee:120$");

    }
}

class OnlineCourse: Course 
{
    public void CourseDetails()
    {
        ShowDetails();
    }
}
class program
{
    static void Main()
    {
      OnlineCourse c= new OnlineCourse();
        Console.WriteLine("The Course Details:-\t");
      c.CourseDetails();
    }



}
