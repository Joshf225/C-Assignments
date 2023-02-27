namespace Assignment4;

public class Canvas
{
  public Stack<Shape> canvas = new Stack<Shape>();
  public string shape { get; set; }

  public void Add(Shape str)
  {
    canvas.Push(str);
    Console.WriteLine("Added shape to canvas");
  }

  public Shape Remove()
  {
    Shape s = canvas.Pop();
    Console.WriteLine("Removed shape from canvas");
    return s;
  }


  public Canvas()
  {
    Console.WriteLine("\nCreated new Canvas");
  }

  public override string ToString()
  {
    int val = canvas.Count;
    string st = "";
    String str = "<!-- " + "Canvas (" + val + " elements):" + " -->"+Environment.NewLine;
    // foreach (Shape s in canvas)
    // {
    //   str += s + Environment.NewLine;
    // }
    // return str;
    Stack<Shape> reversedStack = new Stack<Shape>();
    foreach (Shape s in canvas)
    {
      reversedStack.Push(s);
    }
    foreach (Shape n in reversedStack)
    {
      str += n + Environment.NewLine;
    }
    return str;
  }
}