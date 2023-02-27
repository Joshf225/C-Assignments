namespace Assignment3;

public class Program
{
  public static void Main(string[] args)
  {
    //Creating stack for canvas 
    //One for History for redo method and one to store all items popped 
    //from History list(undo method)
    Stack<String> canvasmem = new Stack<string>();
    Stack<String> history = new Stack<string>();
    canvasmem.Push("<svg viewBox=\"0 0 400 200\" xmlns=\"http://www.w3.org/2000/svg\">");
    history.Push("<svg viewBox=\"0 0 400 200\" xmlns=\"http://www.w3.org/2000/svg\">");
    bool run = true;
    //random number
    Random rnd = new Random();
    // Originator class creates a memento containing a snapshot of its current internal state 
    //and uses the memento to restore its internal state.
    Originator originator = new();
    //Caretaker class is responsible for keeping the mementos. Like maintaining save points and 
    //never operates on or examines the contents of a memento.
    Caretaker caretaker = new();
    Shape tempShape = new Shape();
    int num = rnd.Next(10);
    printHome();
    printCommands();
    while (run) /* Start of Program*/
    {

      string input = Console.ReadLine();
      string inpundercase = input.ToLower();
      var inplet = input.Substring(0);//grab the letter
      string inpletundercase = inplet.ToUpper();//make caps
      if (input.Contains("A"))
      {
        int startIndex = 2;
        int endIndex = input.Length - 2;
        var inpshape = input.Substring(startIndex, endIndex);//grab the shape
        var inpshapeundercase = inpshape.ToLower();//make lowercase
        if (inpshapeundercase == "circle")
        {
          string circle = "";
          circle += tempShape.getCircle();
          originator.shapesClass = new ShapesClass(circle);
          caretaker.addMemento(originator.createMemento());
          canvasmem.Push(originator.getDetails());
          Console.WriteLine("Circle (R=50,X=50,Y=50) added to canvas");
        }
        else if (inpshapeundercase == "rectangle")
        {
          string rectangle = "";
          rectangle += tempShape.getRectangle();
          originator.shapesClass = new ShapesClass(rectangle);
          caretaker.addMemento(originator.createMemento());
          canvasmem.Push(originator.getDetails());
          Console.WriteLine("Rectangle (W=100,H=100) added to canvas");
        }
        else if (inpshapeundercase == "ellipse")
        {
          string ellipse = "";
          ellipse += tempShape.getEllipse();
          originator.shapesClass = new ShapesClass(ellipse);
          caretaker.addMemento(originator.createMemento());
          canvasmem.Push(originator.getDetails());
          Console.WriteLine("Ellipse (CX=100,CY=50,RX=100,RY=50) added to canvas");
        }
        else if (inpshapeundercase == "line")
        {
          string line = "";
          line += tempShape.getLine();
          originator.shapesClass = new ShapesClass(line);
          caretaker.addMemento(originator.createMemento());
          canvasmem.Push(originator.getDetails());
          Console.WriteLine("Line (X1=0,Y1=80,X2=100,Y2=20) added to canvas");
        }
        else if (inpshapeundercase == "polyline")
        {
          string polyline = "";
          polyline += tempShape.getPolyline();
          originator.shapesClass = new ShapesClass(polyline);
          caretaker.addMemento(originator.createMemento());
          canvasmem.Push(originator.getDetails());
          Console.WriteLine("Polyline (Points= 100,100 150,25 150,75 200,0) added to canvas");
        }
        else if (inpshapeundercase == "polygon")
        {
          string polygon = "";
          polygon += tempShape.getPolygon();
          originator.shapesClass = new ShapesClass(polygon);
          caretaker.addMemento(originator.createMemento());
          canvasmem.Push(originator.getDetails());
          Console.WriteLine("Polygon (Points= 100,100 150,25 150,75 200,0) added to canvas");
        }
        else if (inpshapeundercase == "path")
        {
          string path = "";
          path += tempShape.getPath();
          originator.shapesClass = new ShapesClass(path);
          caretaker.addMemento(originator.createMemento());
          canvasmem.Push(originator.getDetails());
          Console.WriteLine("Path (D= M10 10) added to canvas");
        }
      }
      else if (inpletundercase == "H")
      {
        //Help
        printHelp();
      }
      else if (inpletundercase == "C")
      {
        //Clear Canvas
        canvasmem.Clear();
        //Readd the start of the svg file
        canvasmem.Push("<svg viewBox=\"0 0 400 200\" xmlns=\"http://www.w3.org/2000/svg\">");
        Console.WriteLine("Canvas has been cleared!");
      }
      else if (inpletundercase == "Q")
      {
        //Quit
        run = false;
        Console.WriteLine("Bye!");
      }
      else if (inpletundercase == "U")
      {
        //Undo
        //history.Push(canvasmem.Pop());
        //Console.WriteLine("Undo");
        caretaker.undoMemento(canvasmem);
      }
      else if (inpletundercase == "R")
      {
        //Redo
        //canvasmem.Push(history.Pop());
        //Console.WriteLine("Redo");
        caretaker.redoMemento(canvasmem);
      }
      else if (inpletundercase == "D")
      {
        //Display Canvas
        PrintStack(canvasmem);
        Console.WriteLine("</svg>");
      }
      else if (inpletundercase == "S")
      {
        //Save to File
        //canvas.Add("</svg>");
        canvasmem.Push("</svg>");
        //string tempscanvas = "";
        Stack<string> reversedStack = new Stack<string>();
        string tempscanvasmem = "";
        while (canvasmem.Count() > 0)
        {
          reversedStack.Push(canvasmem.Pop());
        }
        foreach (var item in reversedStack) { tempscanvasmem += item + "\n"; }
        //File.WriteAllText("shapes" + num + ".svg", tempscanvas);
        File.WriteAllText("shapes" + num + ".svg", tempscanvasmem);
        Console.WriteLine("Your canvas has been saved in shapes" + num + ".svg");
      }

    }
  }/* End of Program*/

  static void printHome()
  {
    Console.Clear();
    Console.WriteLine("Welcome to My SVG CANVAS UI DEMO");
    Console.WriteLine("==================================");
    Console.WriteLine("(Format boundaries)");
    Console.WriteLine("A <shape> ");
    Console.WriteLine("type H for help");
  }
  static void printCommands()
  {
    Console.WriteLine("Commands:");
    Console.WriteLine("A,S,D,U,R,C,Q");
  }
  static void printHelp()
  {
    Console.Clear();
    Console.WriteLine("Commands:");
    Console.WriteLine("A Add <shape> to canvas");
    Console.WriteLine("S Save current canvas to file");
    Console.WriteLine("D Display current canvas");
    Console.WriteLine("U Undo last operation");
    Console.WriteLine("R Redo last operation");
    Console.WriteLine("C Clear canvas");
    Console.WriteLine("Q Quit application");
  }
  public static string printCanvas(List<String> canv)
  {
    string temp = "";
    foreach (string line in canv)
    {
      Console.WriteLine(line);
      temp += line + "\n";
    }

    return temp;
  }


  public static string PrintStack(Stack<string> s)
  {
    string temp = "";
    // If stack is empty then return
    if (s.Count == 0)
      return "";

    string x = s.Peek();

    // Pop the top element of the stack
    s.Pop();

    // Recursively call the function PrintStack
    PrintStack(s);

    // Print the stack element starting
    // from the bottom
    Console.Write(x + "\n");

    // Push the same element onto the stack
    // to preserve the order
    s.Push(x);
    return x;

  }
  public class Shape
  {
    public string getCircle()
    {
      return "  <circle cx=\"50\" cy=\"50\" r=\"50\" stroke=\"black\" stroke-width=\"3\" fill=\"red\" />";
    }
    public string getRectangle()
    {
      return "  <rect width=\"100\" height=\"100\" style=\"fill:rgb(0,0,255);stroke-width:3;stroke:rgb(0,0,0)\" />";
    }
    public string getEllipse()
    {
      return "  <ellipse cx=\"100\" cy=\"50\" rx=\"100\" ry=\"50\" style=\"fill:yellow;stroke:purple;stroke-width:2\" />";
    }
    public string getLine()
    {
      return "  <line x1=\"0\" y1=\"80\" x2=\"100\" y2=\"20\" stroke=\"black\" />";
    }
    public string getPolyline()
    {
      return "  <polyline points=\"100,100 150,25 150,75 200,0\" fill=\"none\" stroke=\"black\" />";
    }
    public string getPolygon()
    {
      return "  <polygon points=\"100,100 150,25 150,75 200,0\" fill=\"none\" stroke=\"black\" />";
    }
    public string getPath()
    {
      return "  <path d=\"M10 10\"/>";
    }
  }

}
