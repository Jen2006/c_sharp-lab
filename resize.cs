using System.Xml.Serialization;

interface Resize
{
  void resizewidth(int w);  
  void resizeheight(int h);

}

class Rectangle : Resize
{
    private int width;  
    private int height; 

    public Rectangle(int w, int h)
    {
        width = w;
        height = h; 
 
    }

    public void resizewidth(int w)
    {
        width = w;
        Console.WriteLine("Width resized to: " + width);
    }

    public void resizeheight(int h)
    {
        height = h;
        Console.WriteLine("Height resized to: " + height);
    }
    
    public void display()
    {
        Console.WriteLine("Width: " + width + ", Height: " + height);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Rectangle rect = new Rectangle(10, 20);
        rect.display();
        
        rect.resizewidth(30);
        rect.resizeheight(40);
        rect.display();
    }
}
