namespace Assignment5;
/*
                                             READ HERE!!!
                                             I have all Assignments 2,3,and 4 in this folder
                                             to run each one scroll down to the specific assignments
                                             and then uncomment the code to run.
                                             But make sure to comment out everything else so you
                                             dont get errors from duplicate variables.

                                             comment and uncomment by highlighing over code
                                             and CTRL "/"(beside right SHIFT)
*/
class Program
{
  static void Main(string[] args)
  {


    //Command (Assignment 4)
    //===============================================================================
    Console.WriteLine(); Console.WriteLine("==== DEMO START ====");
    Canvas canvas = new Canvas();
    ShapeA2 sha;
    ShapeFactoryA2 s = new ShapeFactoryA2();

    Invoker invoker = new Invoker();

    Console.WriteLine("TEST: ADDING (ADD FOUR SHAPES)"); Console.WriteLine();
    // invoker.Action(new GenerateShape(new Start(), canvas));
    //circle
    var stroke = "h";
    var fill = "j";
    var name = "circle";
    string circ = "";
    sha = s.StyleFactoryMethod(stroke, fill, name);
    sha.getName().Equals("circle");
    { circ += "\n" + sha.nCircle(); }
    invoker.Action(new GenerateShape(circ, canvas));
    // invoker.Action(new GenerateShape(new Start(), canvas));
    //rectangle
    var stroke2 = "h";
    var fill2 = "j";
    name = "rectangle";
    string rect = "";
    sha = s.StyleFactoryMethod(stroke2, fill2, name);
    sha.getName().Equals("rectangle");
    { rect += "\n" + sha.nRectangle(); }
    invoker.Action(new GenerateShape(rect, canvas));
    // invoker.Action(new GenerateShape(new Start(), canvas));
    //ellipse
    var stroke3 = "h";
    var fill3 = "j";
    name = "ellipse";
    string ell = "";
    sha = s.StyleFactoryMethod(stroke3, fill3, name);
    sha.getName().Equals("ellipse");
    { ell += "\n" + sha.nEllipse(); }
    invoker.Action(new GenerateShape(ell, canvas));
    // invoker.Action(new GenerateShape(new Start(), canvas));
    //line
    var stroke4 = "h";
    var fill4 = "j";
    string line = "";
    name = "line";
    sha = s.StyleFactoryMethod(stroke4, fill4, name);
    sha.getName().Equals("line");
    { line += "\n" + sha.nLine(); }
    invoker.Action(new GenerateShape(line, canvas));
    // invoker.Action(new GenerateShape(new Start(), canvas));
    //polyline
    var stroke5 = "h";
    var fill5 = "j";
    string poly = "";
    name = "polyline";
    sha = s.StyleFactoryMethod(stroke5, fill5, name);
    sha.getName().Equals("polyline");
    { poly += "\n" + sha.nPolyline(); }
    invoker.Action(new GenerateShape(poly, canvas));
    // invoker.Action(new GenerateShape(new Start(), canvas));
    //polygon
    var stroke6 = "h";
    var fill6 = "j";
    string pg = "";
    name = "polygon";
    sha.getName().Equals("polygon");
    { pg += "\n" + sha.nPolygon(); }
    sha = s.StyleFactoryMethod(stroke6, fill6, name);
    invoker.Action(new GenerateShape(pg, canvas));
    Console.WriteLine(canvas);
    Console.WriteLine("TEST: DELETE THREE SHAPES"); Console.WriteLine();
    invoker.Action(new DeleteShape(canvas));
    invoker.Action(new DeleteShape(canvas));
    invoker.Action(new DeleteShape(canvas));
    Console.WriteLine(canvas);
    Console.WriteLine("TEST: UNDOING (UNDO)2 DELETED SHAPES"); Console.WriteLine();
    // Undo 2 commands
    invoker.Undo(); invoker.Undo();
    Console.WriteLine(canvas);
    Console.WriteLine("TEST: UNDOING (UNDO)UNDO ONE MORE"); Console.WriteLine();
    // Undo 1 command
    invoker.Undo();
    Console.WriteLine(canvas);
    Console.WriteLine("TEST: ADDING (ADD TWO CIRCLES)"); Console.WriteLine();
    //circle
    var stroke7 = "h";
    var fill7 = "j";
    name = "circle";
    sha.getName().Equals("circle");
    { circ += "\n" + sha.nCircle(); }
    sha = s.StyleFactoryMethod(stroke7, fill7, name);
    invoker.Action(new GenerateShape(circ, canvas));
    //circle
    var stroke8 = "h";
    var fill8 = "j";
    name = "circle";
    sha = s.StyleFactoryMethod(stroke8, fill8, name);
    sha.getName().Equals("ellipse");
    { circ += "\n" + sha.nCircle(); }
    invoker.Action(new GenerateShape(circ, canvas));
    Console.WriteLine(canvas);
    Console.WriteLine("UNDOING: TWICE"); Console.WriteLine();
    invoker.Undo(); invoker.Undo();
    Console.WriteLine(canvas);
    Console.WriteLine("REDOING: ONCE"); Console.WriteLine();
    invoker.Redo();
    Console.WriteLine(canvas);
    Console.WriteLine("==== DEMO END ===="); Console.WriteLine();
    Console.WriteLine("SAVING TO FILE");
    invoker.Action(new Save(canvas));
    Console.ReadKey();
    //End of Command 

    //Memento (Assignment 3)
    //=============================================================================

    // // Creating stack for canvas 
    // // One for History for redo method and one to store all items popped 
    // // from History list(undo method)
    // Stack<Shape> canvasmem = new Stack<Shape>();
    // Stack<Shape> history = new Stack<Shape>();
    // Shape start = new Start();
    // Shape end = new End();
    // canvasmem.Push(start);
    // history.Push(start);
    // bool run = true;
    // //random number
    // Random rnd = new Random();
    // // Originator class creates a memento containing a snapshot of its current internal state 
    // //and uses the memento to restore its internal state.
    // Originator originator = new();
    // //Caretaker class is responsible for keeping the mementos. Like maintaining save points and 
    // //never operates on or examines the contents of a memento.
    // Caretaker caretaker = new();
    // // Shape tempShape = new Shape();
    // int num = rnd.Next(10);
    // printHome();
    // printCommands();
    // while (run) /* Start of Program*/
    // {

    //   string input = Console.ReadLine();
    //   string inpundercase = input.ToLower();
    //   var inplet = input.Substring(0);//grab the letter
    //   string inpletundercase = inplet.ToUpper();//make caps
    //   if (input.Contains("A"))
    //   {
    //     int startIndex = 2;
    //     int endIndex = input.Length - 2;
    //     var inpshape = input.Substring(startIndex, endIndex);//grab the shape
    //     var inpshapeundercase = inpshape.ToLower();//make lowercase
    //     if (inpshapeundercase == "circle")
    //     {
    //       Shape circle = new Circlet();
    //       originator.shapesClass = new ShapesClass(circle);
    //       caretaker.addMemento(originator.createMemento());
    //       canvasmem.Push(originator.getDetails());
    //       Console.WriteLine("Circle added to canvas");
    //     }
    //     else if (inpshapeundercase == "rectangle")
    //     {
    //       Shape rectangle = new Rectanglet();
    //       originator.shapesClass = new ShapesClass(rectangle);
    //       caretaker.addMemento(originator.createMemento());
    //       canvasmem.Push(originator.getDetails());
    //       Console.WriteLine("Rectangle added to canvas");
    //     }
    //     else if (inpshapeundercase == "ellipse")
    //     {
    //       Shape ellipse = new Ellipset();
    //       originator.shapesClass = new ShapesClass(ellipse);
    //       caretaker.addMemento(originator.createMemento());
    //       canvasmem.Push(originator.getDetails());
    //       Console.WriteLine("Ellipse added to canvas");
    //     }
    //     else if (inpshapeundercase == "line")
    //     {
    //       Shape line = new Linet();
    //       originator.shapesClass = new ShapesClass(line);
    //       caretaker.addMemento(originator.createMemento());
    //       canvasmem.Push(originator.getDetails());
    //       Console.WriteLine("Line added to canvas");
    //     }
    //     else if (inpshapeundercase == "polyline")
    //     {
    //       Shape polyline = new Polylinet();
    //       originator.shapesClass = new ShapesClass(polyline);
    //       caretaker.addMemento(originator.createMemento());
    //       canvasmem.Push(originator.getDetails());
    //       Console.WriteLine("Polyline  added to canvas");
    //     }
    //     else if (inpshapeundercase == "polygon")
    //     {
    //       Shape polygon = new Polygont();
    //       originator.shapesClass = new ShapesClass(polygon);
    //       caretaker.addMemento(originator.createMemento());
    //       canvasmem.Push(originator.getDetails());
    //       Console.WriteLine("Polygon  added to canvas");
    //     }
    //   }
    //   else if (inpletundercase == "H")
    //   {
    //     //Help
    //     printHelp();
    //   }
    //   else if (inpletundercase == "C")
    //   {
    //     //Clear Canvas
    //     canvasmem.Clear();
    //     //Readd the start of the svg file
    //     canvasmem.Push(start);
    //     Console.WriteLine("Canvas has been cleared!");
    //   }
    //   else if (inpletundercase == "Q")
    //   {
    //     //Quit
    //     run = false;
    //     Console.WriteLine("Bye!");
    //   }
    //   else if (inpletundercase == "U")
    //   {
    //     //Undo
    //     //history.Push(canvasmem.Pop());
    //     //Console.WriteLine("Undo");
    //     caretaker.undoMemento(canvasmem);
    //   }
    //   else if (inpletundercase == "R")
    //   {
    //     //Redo
    //     //canvasmem.Push(history.Pop());
    //     //Console.WriteLine("Redo");
    //     caretaker.redoMemento(canvasmem);
    //   }
    //   else if (inpletundercase == "D")
    //   {
    //     //Display Canvas
    //     // PrintStack(canvasmem);
    //     string str = "";
    //     Stack<Shape> reversedStack = new Stack<Shape>();
    //     foreach (Shape s in canvasmem)
    //     {
    //       reversedStack.Push(s);
    //     }
    //     foreach (Shape n in reversedStack)
    //     {
    //       str += n + Environment.NewLine;
    //     }
    //     foreach (var s in reversedStack)
    //     {
    //       Console.WriteLine(s);
    //     }
    //     Console.WriteLine(end);
    //   }
    //   else if (inpletundercase == "S")
    //   {
    //     //Save to File
    //     //canvas.Add("</svg>");
    //     canvasmem.Push(end);
    //     //string tempscanvas = "";
    //     Stack<Shape> reversedStack = new Stack<Shape>();
    //     string tempscanvasmem = "";
    //     while (canvasmem.Count() > 0)
    //     {
    //       reversedStack.Push(canvasmem.Pop());
    //     }
    //     foreach (var item in reversedStack) { tempscanvasmem += item + "\n"; }
    //     //File.WriteAllText("shapes" + num + ".svg", tempscanvas);
    //     File.WriteAllText("shapes" + num + ".svg", tempscanvasmem);
    //     Console.WriteLine("Your canvas has been saved in shapes" + num + ".svg");
    //   }

    // }

    //End of Memento
    //==============================================================================

    //Assignment 2
    //===================================================================================================

    // shapesA2 sh = new shapesA2();
    // var fill = "hello";
    // var stroke = "blue";
    // sh.style(fill, stroke);
    // var circle = sh.getShape();

    // LinkedList<ShapeA2> shapes = new LinkedList<ShapeA2>();
    // ShapeFactoryA2 s = new ShapeFactoryA2();
    // Random rnd = new Random();
    // int num = rnd.Next(100);
    // int ind = 1;
    // string svg = "";
    // Console.Clear();
    // Console.WriteLine("Welcome to My SVG CANVAS UI DEMO");
    // Console.WriteLine("==================================");
    // Console.WriteLine("\n \nChoose your option;");
    // //On select user will be given options to select the shape they want
    // Console.WriteLine("\n1)Add Shape");
    // //On select user will be given other options for editing the shapes 
    // //and it's attributes
    // Console.WriteLine("2)Delete/Edit Shapes");
    // //Delete shape
    // //Show the shapes you selected as SVG
    // Console.WriteLine("3)Save and View");
    // //Exit Canvas
    // Console.WriteLine("4)Quit!");

    // bool run = true;

    // while (run == true)
    // {
    //   ShapeA2 newshape = new ShapeA2();
    //   ShapeA2 tempShape = new ShapeA2();
    //   ShapeA2 sha;
    //   string input = Console.ReadLine();
    //   int var = Convert.ToInt32(input);
    //   switch (var)
    //   {
    //     case 1:
    //       //==================================================Start of Case 1=============================================
    //       Console.Clear();
    //       Console.WriteLine("You chose option 1");
    //       Console.WriteLine("Choose what shape you want!");
    //       Console.WriteLine("Circle");
    //       Console.WriteLine("Rectangle");
    //       Console.WriteLine("Ellipse");
    //       Console.WriteLine("Line");
    //       Console.WriteLine("Polyline");
    //       Console.WriteLine("Polygon");
    //       string inp1 = Console.ReadLine();
    //       string input1 = inp1.ToLower();
    //       switch (input1)
    //       {
    //         case "circle":
    //           //================================Start of case a==============================================
    //           Console.Clear();
    //           Console.WriteLine("Circle");
    //           Console.WriteLine("Enter length");
    //           int cx = Convert.ToInt32(Console.ReadLine());
    //           Console.WriteLine("Enter width");
    //           int cy = Convert.ToInt32(Console.ReadLine());
    //           Console.WriteLine("Enter radius");
    //           int r = Convert.ToInt32(Console.ReadLine());
    //           Console.WriteLine("Enter fill");
    //           string fill1 = Console.ReadLine();
    //           Console.WriteLine("Enter stroke(colour)");
    //           string stroke1 = Console.ReadLine();
    //           // newshape.circle(input1,cx,cy,r,fill1,stroke1);
    //           // shapes.AddFirst(newshape);
    //           var circle = s.CircleFactoryMethod(input1, cx, cy, r, fill1, stroke1, ind++);
    //           // tempShape.circle(input1, cx, cy, r, fill1, stroke1, ind++);
    //           // shapes.AddFirst(tempShape);
    //           shapes.AddFirst(circle);
    //           PrintHome();
    //           break;
    //         //================================End of case a==============================================
    //         //Rectangle Option
    //         case "rectangle":
    //           //================================================== Start of case b ==============================
    //           Console.Clear();
    //           Console.WriteLine("Rectangle");
    //           //Shape rect = new Rectangle();
    //           Console.WriteLine("Enter x");
    //           int wX = Convert.ToInt32(Console.ReadLine());
    //           Console.WriteLine("Enter y");
    //           int wY = Convert.ToInt32(Console.ReadLine());
    //           Console.WriteLine("Enter width");
    //           int width = Convert.ToInt32(Console.ReadLine());
    //           Console.WriteLine("Enter height");
    //           int height = Convert.ToInt32(Console.ReadLine());
    //           Console.WriteLine("Enter fill");
    //           string fill2 = Console.ReadLine();
    //           Console.WriteLine("Enter stroke(colour)");
    //           string stroke2 = Console.ReadLine();
    //           sha = s.RectangleFactoryMethod(input1, wX, wY, width, height, fill2, stroke2, ind++);
    //           // tempShape.rectangle(input1, wX, wY, width, height, fill2, stroke2, ind++);
    //           // shapes.AddFirst(tempShape);
    //           shapes.AddFirst(sha);
    //           PrintHome();
    //           break;
    //         //================================End of case b==============================================
    //         case "ellipse":
    //           //============================================== Start of case c ==============================
    //           Console.Clear();
    //           Console.WriteLine("Ellipse");
    //           //Shape ellipse = new Ellipse();
    //           Console.WriteLine("Enter length");
    //           int ecx = Convert.ToInt32(Console.ReadLine());
    //           Console.WriteLine("Enter width");
    //           int ecy = Convert.ToInt32(Console.ReadLine());
    //           Console.WriteLine("Enter Radius X");
    //           int rx = Convert.ToInt32(Console.ReadLine());
    //           Console.WriteLine("Enter Radius Y");
    //           int ry = Convert.ToInt32(Console.ReadLine());
    //           Console.WriteLine("Enter fill");
    //           string fill3 = Console.ReadLine();
    //           Console.WriteLine("Enter stroke");
    //           string stroke3 = Console.ReadLine();
    //           sha = s.EllipseFactoryMethod(input1, ecx, ecy, rx, ry, fill3, stroke3, ind++);
    //           // tempShape.ellipse(input1, ecx, ecy, rx, ry, fill3, stroke3, ind++);
    //           // shapes.AddFirst(tempShape);
    //           shapes.AddFirst(sha);
    //           PrintHome();
    //           break;
    //         //=============================End of Case c ==========================================
    //         case "line":
    //           //===============================Start of case d=============================================================
    //           Console.Clear();
    //           Console.WriteLine("Line");
    //           //Shape line = new Line();
    //           Console.WriteLine("Enter X1");
    //           int lx1 = Convert.ToInt32(Console.ReadLine());
    //           Console.WriteLine("Enter Y1");
    //           int ly1 = Convert.ToInt32(Console.ReadLine());
    //           Console.WriteLine("Enter X2");
    //           int lx2 = Convert.ToInt32(Console.ReadLine());
    //           Console.WriteLine("Enter Y2");
    //           int ly2 = Convert.ToInt32(Console.ReadLine());
    //           Console.WriteLine("Enter Stroke width");
    //           int lstroke = Convert.ToInt32(Console.ReadLine());
    //           Console.WriteLine("Enter Stroke(colour)");
    //           string stroke4 = Console.ReadLine();
    //           sha = s.LineFactoryMethod(input1, lx1, ly1, lx2, ly2, lstroke, stroke4, ind++);
    //           // tempShape.line(input1, lx1, ly1, lx2, ly2, lstroke, stroke4, ind++);
    //           // shapes.AddFirst(tempShape);
    //           shapes.AddFirst(sha);
    //           PrintHome();
    //           break;
    //         //=================================End of case d==========================================================
    //         case "polyline":
    //           //======================================Start of case e======================================================
    //           Console.Clear();
    //           Console.WriteLine("Polyline");
    //           //Shape polyline = new Polyline();
    //           Console.WriteLine("Enter point 1");
    //           int p1 = Convert.ToInt32(Console.ReadLine());
    //           Console.WriteLine("Enter point 2");
    //           int p2 = Convert.ToInt32(Console.ReadLine());
    //           Console.WriteLine("Enter point 3");
    //           int p3 = Convert.ToInt32(Console.ReadLine());
    //           Console.WriteLine("Enter point 4");
    //           int p4 = Convert.ToInt32(Console.ReadLine());
    //           Console.WriteLine("Enter point 5");
    //           int p5 = Convert.ToInt32(Console.ReadLine());
    //           Console.WriteLine("Enter point 6");
    //           int p6 = Convert.ToInt32(Console.ReadLine());
    //           Console.WriteLine("Enter point 7");
    //           int p7 = Convert.ToInt32(Console.ReadLine());
    //           Console.WriteLine("Enter point 8");
    //           int p8 = Convert.ToInt32(Console.ReadLine());
    //           //My factory method 
    //           sha = s.PolylineFactoryMethod(input1, p1, p2, p3, p4, p5, p6, p7, p8, ind++);
    //           // tempShape.polyline(input1, p1, p2, p3, p4, p5, p6, p7, p8, ind++);
    //           // shapes.AddFirst(tempShape);
    //           shapes.AddFirst(sha);
    //           PrintHome();
    //           break;
    //         //======================================End of case e======================================================
    //         case "polygon":
    //           //======================================Start of case f======================================================
    //           Console.Clear();
    //           Console.WriteLine("Polygon");
    //           //Shape polygon = new Polygon();
    //           Console.WriteLine("Enter point 1");
    //           int pg1 = Convert.ToInt32(Console.ReadLine());
    //           Console.WriteLine("Enter point 2");
    //           int pg2 = Convert.ToInt32(Console.ReadLine());
    //           Console.WriteLine("Enter point 3");
    //           int pg3 = Convert.ToInt32(Console.ReadLine());
    //           Console.WriteLine("Enter point 4");
    //           int pg4 = Convert.ToInt32(Console.ReadLine());
    //           Console.WriteLine("Enter point 5");
    //           int pg5 = Convert.ToInt32(Console.ReadLine());
    //           Console.WriteLine("Enter point 6");
    //           int pg6 = Convert.ToInt32(Console.ReadLine());
    //           Console.WriteLine("Enter point 7");
    //           int pg7 = Convert.ToInt32(Console.ReadLine());
    //           Console.WriteLine("Enter point 8");
    //           int pg8 = Convert.ToInt32(Console.ReadLine());
    //           sha = s.PolygonFactoryMethod(input1, pg1, pg2, pg3, pg4, pg5, pg6, pg7, pg8, ind++);
    //           // tempShape.polygon(input1, pg1, pg2, pg3, pg4, pg5, pg6, pg7, pg8, ind++);
    //           // shapes.AddFirst(tempShape);
    //           shapes.AddFirst(sha);
    //           PrintHome();
    //           break;
    //         //======================================End of case f======================================================
    //         case "path":
    //           //======================================Start of case g======================================================
    //           Console.Clear();
    //           Console.WriteLine("Path");
    //           //Shape path = new Path();
    //           Console.WriteLine("Enter your X coordinate");
    //           int pathd1 = Convert.ToInt32(Console.ReadLine());
    //           Console.WriteLine("Enter your Y coordinate");
    //           int pathd2 = Convert.ToInt32(Console.ReadLine());
    //           sha = s.PathFactoryMethod(input1, pathd1, pathd2, ind++);
    //           // tempShape.path(input1, pathd1, pathd2, ind++);
    //           // shapes.AddFirst(tempShape);
    //           shapes.AddFirst(sha);
    //           PrintHome();
    //           break;
    //           //======================================End of case g======================================================
    //       }
    //       //==================================================End of Case 1=============================================
    //       break;
    //     case 2:
    //       //Delete and Edit
    //       run = true;
    //       //create loop to continously ask user to update or delete shapes
    //       //stop loop if user is finished
    //       while (run)
    //       {
    //         Console.WriteLine("What would you like to edit or delete?\nSelect Index: ");
    //         foreach (ShapeA2 ss in shapes) { ss.getShape(); }
    //         int index = Convert.ToInt32(Console.ReadLine());
    //         Console.WriteLine("a = Delete\nb = Update");
    //         string input3 = Console.ReadLine();
    //         if (input3.Equals("a") || input3.Equals("A")) { deleteShape(shapes, index); }
    //         else { updateList(shapes, index); }
    //         svg = createSVG(shapes);
    //         Console.WriteLine("Press Enter to save and exit or 1 to edit a different shape");
    //         //sometimes editing multiple shapes messes up so just restart and select 
    //         //the shape that messed up and you can edit and delete , thanks!b
    //         if (String.IsNullOrEmpty(Console.ReadLine()))
    //         {
    //           svg = createSVG(shapes);
    //           //creates separate files every game
    //           run = false; File.WriteAllText("shapes" + num + ".svg", svg);
    //           Console.WriteLine("Your SVG File: " + "\n" + svg + "\nYour SVG file is saved as shapes" + num + ".svg");
    //         }
    //         else
    //         {
    //           svg = createSVG(shapes);
    //         }
    //       }
    //       break;
    //     case 3:
    //       //Save and View
    //       Console.WriteLine("You chose option 3");
    //       svg = createSVG(shapes);
    //       //creates separate files every game
    //       File.WriteAllText("shapes" + num + ".svg", svg);
    //       Console.WriteLine("Your SVG File: " + "\n" + svg + "\nYour SVG file is saved as shapes" + num + ".svg");
    //       Console.WriteLine("PRESS 2 TO EDIT!!");
    //       break;
    //       run = false;
    //     case 4:
    //       //Quit
    //       Console.WriteLine("You Quit!");
    //       Console.WriteLine("Goodbye!");
    //       run = false;
    //       break;
    //     default:
    //       Console.WriteLine("Incorrect input");
    //       break;
    //   }
    // }

    //==================================================================================================
  }
  static void printHome()
  {
    Console.Clear();
    Console.WriteLine("Welcome to My SVG CANVAS UI DEMO");
    Console.WriteLine("==================================");
    Console.WriteLine("(Format boundaries)");
    Console.WriteLine("A <shape> ");
    Console.WriteLine("type H for help");
  }
  static void PrintHome()
  {
    Console.Clear();
    Console.WriteLine("Welcome to My SVG CANVAS UI DEMO");
    Console.WriteLine("==================================");
    Console.WriteLine("\n \nChoose your option;");
    //On select user will be given options to select the shape they want
    Console.WriteLine("\n1)Add Shape");
    //On select user will be given other options for editing the shapes 
    //and it's attributes
    Console.WriteLine("2)Delete/Edit Shapes");
    Console.WriteLine("3)Save and View");
    //Exit Canvas
    Console.WriteLine("4)Quit!");
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
  public static string printCanvas(List<Shape> canv)
  {
    string temp = "";
    foreach (Shape line in canv)
    {
      Console.WriteLine(line);
      temp += line + "\n";
    }

    return temp;
  }


  public static string PrintStack(Stack<Shape> canvas)
  {
    String str = "";
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
  public static string createSVG(LinkedList<ShapeA2> shape)
  {
    string start = "<svg width=\"300\" height=\"300\" version=\"1.1\" xmlns=\"http://www.w3.org/2000/svg\">";
    string middle = "";
    string end = "</svg>";
    foreach (ShapeA2 s in shape)
    {
      if (s.getName().Equals("rectangle")) { middle += "\n" + s.getRectangle(); }
      else if (s.getName().Equals("circle")) { middle += "\n" + s.getCircle(); }
      else if (s.getName().Equals("ellipse")) { middle += "\n" + s.getEllipse(); }
      else if (s.getName().Equals("line")) { middle += "\n" + s.getLine(); }
      else if (s.getName().Equals("polyline")) { middle += "\n" + s.getPolyline(); }
      else if (s.getName().Equals("polygon")) { middle += "\n" + s.getPolygon(); }
      else if (s.getName().Equals("path")) { middle += "\n" + s.getPath(); }
    }
    return start + middle + "\n" + end;
  }

  public static void deleteShape(LinkedList<ShapeA2> shape, int index)
  {
    ShapeA2 temp = new ShapeA2();
    foreach (ShapeA2 s in shape)
    {
      if (index == s.getIndex()) { temp = s; }
    }
    shape.Remove(temp);
  }

  public static void updateList(LinkedList<ShapeA2> shape, int index)
  {
    foreach (ShapeA2 s in shape)
    {
      if (index == s.getIndex())
      {
        if (s.getName().Equals("circle"))
        {
          Console.WriteLine("New cx value: ");
          s.setcx(Convert.ToInt32(Console.ReadLine()));
          Console.WriteLine("New cy value: ");
          s.setcy(Convert.ToInt32(Console.ReadLine()));
          Console.WriteLine("New radius value: ");
          s.setr(Convert.ToInt32(Console.ReadLine()));
          Console.WriteLine("New stroke width value: ");
          s.setStrokeWidth(Convert.ToInt32(Console.ReadLine()));
          Console.WriteLine("New fill value (colour): ");
          s.setfill(Console.ReadLine());
          Console.WriteLine("New stroke value (colour): ");
          s.setstroke(Console.ReadLine());
        }
        else if (s.getName().Equals("rectangle"))
        {
          Console.WriteLine("New wX value: ");
          s.setwX(Convert.ToInt32(Console.ReadLine()));
          Console.WriteLine("New wY value: ");
          s.setcy(Convert.ToInt32(Console.ReadLine()));
          Console.WriteLine("New width value: ");
          s.setwidth(Convert.ToInt32(Console.ReadLine()));
          Console.WriteLine("New height width value: ");
          s.setheight(Convert.ToInt32(Console.ReadLine()));
          Console.WriteLine("New stroke width value: ");
          s.setStrokeWidth(Convert.ToInt32(Console.ReadLine()));
          Console.WriteLine("New fill value (colour): ");
          s.setfill(Console.ReadLine());
          Console.WriteLine("New stroke value (colour): ");
          s.setstroke(Console.ReadLine());
        }
        else if (s.getName().Equals("ellipse"))
        {
          Console.WriteLine("New ecx value: ");
          s.setecx(Convert.ToInt32(Console.ReadLine()));
          Console.WriteLine("New ecy value: ");
          s.setecy(Convert.ToInt32(Console.ReadLine()));
          Console.WriteLine("New rx value: ");
          s.setrx(Convert.ToInt32(Console.ReadLine()));
          Console.WriteLine("New ry width value: ");
          s.setry(Convert.ToInt32(Console.ReadLine()));
          Console.WriteLine("New stroke width value: ");
          s.setStrokeWidth(Convert.ToInt32(Console.ReadLine()));
          Console.WriteLine("New fill value (colour): ");
          s.setfill(Console.ReadLine());
          Console.WriteLine("New stroke value (colour): ");
          s.setstroke(Console.ReadLine());
        }
        else if (s.getName().Equals("line"))
        {
          Console.WriteLine("New x1 value: ");
          s.setlx1(Convert.ToInt32(Console.ReadLine()));
          Console.WriteLine("New y1 value: ");
          s.setly1(Convert.ToInt32(Console.ReadLine()));
          Console.WriteLine("New x2 value: ");
          s.setlx2(Convert.ToInt32(Console.ReadLine()));
          Console.WriteLine("New y2 width value: ");
          s.setly2(Convert.ToInt32(Console.ReadLine()));
          Console.WriteLine("New stroke width value: ");
          s.setStrokeWidth(Convert.ToInt32(Console.ReadLine()));
          Console.WriteLine("New fill value (colour): ");
          s.setfill(Console.ReadLine());
          Console.WriteLine("New stroke value (colour): ");
          s.setstroke(Console.ReadLine());
        }
        else if (s.getName().Equals("polygon"))
        {
          Console.WriteLine("New point 1 value: ");
          s.setpg1(Convert.ToInt32(Console.ReadLine()));
          Console.WriteLine("New point 2 value: ");
          s.setpg2(Convert.ToInt32(Console.ReadLine()));
          Console.WriteLine("New point 3 value: ");
          s.setpg3(Convert.ToInt32(Console.ReadLine()));
          Console.WriteLine("New point 4 width value: ");
          s.setpg4(Convert.ToInt32(Console.ReadLine()));
          Console.WriteLine("New point 5 value: ");
          s.setpg5(Convert.ToInt32(Console.ReadLine()));
          Console.WriteLine("New point 6 value: ");
          s.setpg6(Convert.ToInt32(Console.ReadLine()));
          Console.WriteLine("New point 7 value: ");
          s.setpg7(Convert.ToInt32(Console.ReadLine()));
          Console.WriteLine("New point 8 value: ");
          s.setpg8(Convert.ToInt32(Console.ReadLine()));
          Console.WriteLine("New stroke width value: ");
          s.setStrokeWidth(Convert.ToInt32(Console.ReadLine()));
          Console.WriteLine("New fill value (colour): ");
          s.setfill(Console.ReadLine());
          Console.WriteLine("New stroke value (colour): ");
          s.setstroke(Console.ReadLine());
        }
        else if (s.getName().Equals("polygon"))
        {
          Console.WriteLine("New Path direction 1 value: ");
          s.setpathd1(Convert.ToInt32(Console.ReadLine()));
          Console.WriteLine("New Path direction 2 value: ");
          s.setpathd2(Convert.ToInt32(Console.ReadLine()));
          Console.WriteLine("New stroke width value: ");
          s.setStrokeWidth(Convert.ToInt32(Console.ReadLine()));
          Console.WriteLine("New fill value (colour): ");
          s.setfill(Console.ReadLine());
          Console.WriteLine("New stroke value (colour): ");
          s.setstroke(Console.ReadLine());
        }
      }
    }
  }

}
// Shape s = new Start();
// Shape c = new Circlet();
// Shape e = new Ellipset();
// Shape l = new Linet();
// Shape p = new Polylinet();
// Shape pg = new Polygont();
// Console.WriteLine(e);
// Console.WriteLine(l);
// Console.WriteLine(p);
// Console.WriteLine(pg);
// Console.WriteLine(s);
// Console.WriteLine(c);
