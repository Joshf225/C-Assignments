namespace Assignment3;

//For the extra credits the three I chose are
//(i)	include	 commands	 specifying	 parameters	 to	 create	specific shapes	
// (other	 than	 randomly	 created shapes)	as	part	 fo	 the	command
//(ii)	include	commands	for	 applying	 basic	 styles	 for	 generated	 shapes
// (iii)	 include	 commands	 for	 canvas	manipulation,	 i.e	translating,	 
//rotating,	 skewing	and	 scaling	 the	canvas
public class Program
{
  public static void Main(string[] args)
  {
    //Creating stack for canvas 
    //One for History for redo method and one to store all items popped 
    //from History list(undo method)
    //My Memento design works by ...
    //My shapes class is what I use to get the data from the user and I use my Memento Class
    ///to store the data and I have an addittional method to access the data. But none are accessable to read
    //I have an originator class that has a method to create a memento and get the details in the memento
    Stack<string> canvasmem = new Stack<string>();
    canvasmem.Push("<svg viewBox=\"0 0 100 100\" xmlns=\"http://www.w3.org/2000/svg\">");

    bool run = true;
    //random number
    Random rnd = new Random();
    //caretaker class to access the history from memento and 
    //originator class to access the data from caretaker class
    Originator originator = new();
    Caretaker caretaker = new();
    Shape tempShape = new Shape();
    int num = rnd.Next(10);
    printHome();
    printCommands();
    while (run) /* Start of Program*/
    {

      string inp = Console.ReadLine();
      string input = inp.ToUpper();
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
          LinkedList<Shape> tempshapes = new LinkedList<Shape>();
          string circles = "";
          Console.WriteLine("Enter length");
          int x = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Enter width");
          int y = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Enter radius");
          int r = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Enter stroke (colour)");
          string stroke = Console.ReadLine();
          Console.WriteLine("Enter fill");
          string fill = Console.ReadLine();
          Console.WriteLine("Enter stroke-width(number)");
          int strokewidth = Convert.ToInt32(Console.ReadLine());
          tempShape.circle(x, y, r, stroke, strokewidth, fill);
          tempshapes.AddFirst(tempShape);
          foreach (var item in tempshapes) { circles += item.getCircle(); }
          //canvas.Add(circle);
          //using originator class to access the data from the memento class
          //through 
          originator.shapesClass = new ShapesClass(circles);
          caretaker.addMemento(originator.createMemento());
          canvasmem.Push(originator.getDetails());
          Console.Clear();
          Console.WriteLine("Circle added to canvas");
        }
        else if (inpshapeundercase == "rectangle")
        {
          LinkedList<Shape> tempshapes = new LinkedList<Shape>();
          string rectangle = "";
          Console.WriteLine("Enter x");
          int x = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Enter y");
          int y = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Enter width");
          int w = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Enter height");
          int h = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Enter stroke (colour)");
          string stroke = Console.ReadLine();
          Console.WriteLine("Enter fill");
          string fill = Console.ReadLine();
          Console.WriteLine("Enter stroke-width(number)");
          int strokewidth = Convert.ToInt32(Console.ReadLine());
          tempShape.rectangle(x, y, w, h, stroke, strokewidth, fill);
          tempshapes.AddFirst(tempShape); ;
          foreach (var item in tempshapes) { rectangle += item.getRectangle(); }
          //canvas.Add(rectangle);
          originator.shapesClass = new ShapesClass(rectangle);
          caretaker.addMemento(originator.createMemento());
          canvasmem.Push(originator.getDetails());
          Console.Clear();
          Console.WriteLine("Rectangle added to canvas");
        }
        else if (inpshapeundercase == "ellipse")
        {
          LinkedList<Shape> tempshapes = new LinkedList<Shape>();
          string ellipse = "";
          Console.WriteLine("Enter length");
          int x = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Enter width");
          int y = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Enter Radius X");
          int x2 = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Enter Radius Y");
          int y2 = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Enter stroke (colour)");
          string stroke = Console.ReadLine();
          Console.WriteLine("Enter fill");
          string fill = Console.ReadLine();
          Console.WriteLine("Enter stroke-width(number)");
          int strokewidth = Convert.ToInt32(Console.ReadLine());
          tempShape.ellipse(x, y, x2, y2, stroke, strokewidth, fill);
          tempshapes.AddFirst(tempShape); ;
          foreach (var item in tempshapes) { ellipse += item.getEllipse(); }
          originator.shapesClass = new ShapesClass(ellipse);
          caretaker.addMemento(originator.createMemento());
          canvasmem.Push(originator.getDetails());
          Console.Clear();
          Console.WriteLine("Ellipse added to canvas");
        }
        else if (inpshapeundercase == "line")
        {
          LinkedList<Shape> tempshapes = new LinkedList<Shape>();
          string line = "";
          Console.WriteLine("Enter X1");
          int x = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Enter Y1");
          int y = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Enter X2");
          int x2 = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Enter Y2");
          int y2 = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Enter stroke (colour)");
          string stroke = Console.ReadLine();
          Console.WriteLine("Enter fill");
          string fill = Console.ReadLine();
          Console.WriteLine("Enter stroke-width(number)");
          int strokewidth = Convert.ToInt32(Console.ReadLine());
          tempShape.line(x, y, x2, y2, stroke, strokewidth, fill);
          tempshapes.AddFirst(tempShape); ;
          foreach (var item in tempshapes) { line += item.getLine(); }
          originator.shapesClass = new ShapesClass(line);
          caretaker.addMemento(originator.createMemento());
          canvasmem.Push(originator.getDetails());
          Console.Clear();
          Console.WriteLine("Line added to canvas");
        }
        else if (inpshapeundercase == "polyline")
        {
          LinkedList<Shape> tempshapes = new LinkedList<Shape>();
          string polyline = "";
          Console.WriteLine("Enter point 1");
          int p1 = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Enter point 2");
          int p2 = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Enter point 3");
          int p3 = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Enter point 4");
          int p4 = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Enter point 5");
          int p5 = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Enter point 6");
          int p6 = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Enter point 7");
          int p7 = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Enter point 8");
          int p8 = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Enter stroke (colour)");
          string stroke = Console.ReadLine();
          Console.WriteLine("Enter fill");
          string fill = Console.ReadLine();
          Console.WriteLine("Enter stroke-width(number)");
          int strokewidth = Convert.ToInt32(Console.ReadLine());
          tempShape.polyline(p1, p2, p3, p4, p5, p6, p7, p8, stroke, strokewidth, fill);
          tempshapes.AddFirst(tempShape); ;
          foreach (var item in tempshapes) { polyline += item.getPolyline(); }
          originator.shapesClass = new ShapesClass(polyline);
          caretaker.addMemento(originator.createMemento());
          canvasmem.Push(originator.getDetails());
          Console.Clear();
          Console.WriteLine("Polyline added to canvas");
        }
        else if (inpshapeundercase == "polygon")
        {
          LinkedList<Shape> tempshapes = new LinkedList<Shape>();
          string polygon = "";
          Console.WriteLine("Enter point 1");
          int p1 = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Enter point 2");
          int p2 = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Enter point 3");
          int p3 = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Enter point 4");
          int p4 = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Enter point 5");
          int p5 = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Enter point 6");
          int p6 = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Enter point 7");
          int p7 = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Enter point 8");
          int p8 = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Enter stroke (colour)");
          string stroke = Console.ReadLine();
          Console.WriteLine("Enter fill");
          string fill = Console.ReadLine();
          Console.WriteLine("Enter stroke-width(number)");
          int strokewidth = Convert.ToInt32(Console.ReadLine());
          tempShape.polygon(p1, p2, p3, p4, p5, p6, p7, p8, stroke, strokewidth, fill);
          tempshapes.AddFirst(tempShape); ;
          foreach (var item in tempshapes) { polygon += item.getPolygon(); }
          originator.shapesClass = new ShapesClass(polygon);
          caretaker.addMemento(originator.createMemento());
          canvasmem.Push(originator.getDetails());
          Console.Clear();
          Console.WriteLine("Polygon added to canvas");
        }
        else if (inpshapeundercase == "path")
        {
          LinkedList<Shape> tempshapes = new LinkedList<Shape>();
          string path = "";
          Console.WriteLine("Enter your X coordinate");
          int p1 = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Enter your Y coordinate");
          int p2 = Convert.ToInt32(Console.ReadLine());
          tempShape.path(p1, p2);
          tempshapes.AddFirst(tempShape); ;
          foreach (var item in tempshapes) { path += item.getPath(); }
          originator.shapesClass = new ShapesClass(path);
          caretaker.addMemento(originator.createMemento());
          canvasmem.Push(originator.getDetails());
          Console.Clear();
          Console.WriteLine("Path added to canvas");
        }
      }
      else if (inpletundercase == "T")
      {
        //Canvas Manipulation
        //When using T in cdm add a manipulation then enter done and then enter t if you want to add another
        Console.WriteLine("Manipulation");
        Console.WriteLine("Forms of Manipulations :translate,rotate,skewing,scale");
        Console.WriteLine("Enter \"Done \" if/when done");
        bool edit = false;
        while (edit == false)
        {
          LinkedList<Shape> tempshapes = new LinkedList<Shape>();
          LinkedList<Shape> trans = new LinkedList<Shape>();
          string s = Console.ReadLine();
          string sh = s.ToLower();
          if (sh == "translate")
          {
            Console.WriteLine("What shape in the canvas do you want to translate?");
            Console.WriteLine("Write shape:");
            string t = Console.ReadLine();
            string temp = t.ToLower();
            if (temp == "circle")
            {
              string circlest = "";
              Console.WriteLine("Enter length");
              int x = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter width");
              int y = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter radius");
              int r = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter stroke (colour)");
              string stroke = Console.ReadLine();
              Console.WriteLine("Enter fill");
              string fill = Console.ReadLine();
              Console.WriteLine("Enter stroke-width(number)");
              int strokewidth = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter translate");
              string translate = Console.ReadLine();
              tempShape.circlet(x, y, r, stroke, strokewidth, fill, translate);
              tempshapes.AddFirst(tempShape);
              foreach (var item in tempshapes) { circlest += item.getCircleT(); }
              //canvas.Add(circle);
              //using originator class to access the data from the memento class
              //through 
              originator.shapesClass = new ShapesClass(circlest);
              caretaker.addMemento(originator.createMemento());
              canvasmem.Push(originator.getDetails());
              Console.Clear();
              Console.WriteLine("Circle translation added to canvas");
              Console.WriteLine("type done when finished");
            }
            else if (temp == "rectangle")
            {
              string rectanglet = "";
              Console.WriteLine("Enter x");
              int x = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter y");
              int y = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter width");
              int w = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter height");
              int h = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter stroke (colour)");
              string stroke = Console.ReadLine();
              Console.WriteLine("Enter fill");
              string fill = Console.ReadLine();
              Console.WriteLine("Enter stroke-width(number)");
              int strokewidth = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter translate");
              string translate = Console.ReadLine();
              tempShape.rectanglet(x, y, w, h, stroke, strokewidth, fill, translate);
              tempshapes.AddFirst(tempShape); ;
              foreach (var item in tempshapes) { rectanglet += item.getRectangleT(); }
              //canvas.Add(rectangle);
              originator.shapesClass = new ShapesClass(rectanglet);
              caretaker.addMemento(originator.createMemento());
              canvasmem.Push(originator.getDetails());
              Console.Clear();
              Console.WriteLine("Rectangle translate added to canvas");
              Console.WriteLine("type done when finished");
            }
            else if (temp == "ellipse")
            {
              string ellipset = "";
              Console.WriteLine("Enter length");
              int x = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter width");
              int y = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter Radius X");
              int x2 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter Radius Y");
              int y2 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter stroke (colour)");
              string stroke = Console.ReadLine();
              Console.WriteLine("Enter fill");
              string fill = Console.ReadLine();
              Console.WriteLine("Enter stroke-width(number)");
              int strokewidth = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter translate");
              string translate = Console.ReadLine();
              tempShape.ellipset(x, y, x2, y2, stroke, strokewidth, fill, translate);
              tempshapes.AddFirst(tempShape); ;
              foreach (var item in tempshapes) { ellipset += item.getEllipseT(); }
              originator.shapesClass = new ShapesClass(ellipset);
              caretaker.addMemento(originator.createMemento());
              canvasmem.Push(originator.getDetails());
              Console.Clear();
              Console.WriteLine("Ellipse tranlation added to canvas");
              Console.WriteLine("type done when finished");
            }
            else if (temp == "line")
            {
              string linet = "";
              Console.WriteLine("Enter X1");
              int x = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter Y1");
              int y = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter X2");
              int x2 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter Y2");
              int y2 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter stroke (colour)");
              string stroke = Console.ReadLine();
              Console.WriteLine("Enter fill");
              string fill = Console.ReadLine();
              Console.WriteLine("Enter stroke-width(number)");
              int strokewidth = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter translate");
              string translate = Console.ReadLine();
              tempShape.linet(x, y, x2, y2, stroke, strokewidth, fill, translate);
              tempshapes.AddFirst(tempShape); ;
              foreach (var item in tempshapes) { linet += item.getLineT(); }
              originator.shapesClass = new ShapesClass(linet);
              caretaker.addMemento(originator.createMemento());
              canvasmem.Push(originator.getDetails());
              Console.Clear();
              Console.WriteLine("Line translation added to canvas");
              Console.WriteLine("type done when finished");
            }
            else if (temp == "polyline")
            {
              string polylinet = "";
              Console.WriteLine("Enter point 1");
              int p1 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter point 2");
              int p2 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter point 3");
              int p3 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter point 4");
              int p4 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter point 5");
              int p5 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter point 6");
              int p6 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter point 7");
              int p7 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter point 8");
              int p8 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter stroke (colour)");
              string stroke = Console.ReadLine();
              Console.WriteLine("Enter fill");
              string fill = Console.ReadLine();
              Console.WriteLine("Enter stroke-width(number)");
              int strokewidth = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter translate");
              string translate = Console.ReadLine();
              tempShape.polylinet(p1, p2, p3, p4, p5, p6, p7, p8, stroke, strokewidth, fill, translate);
              tempshapes.AddFirst(tempShape); ;
              foreach (var item in tempshapes) { polylinet += item.getPolylineT(); }
              originator.shapesClass = new ShapesClass(polylinet);
              caretaker.addMemento(originator.createMemento());
              canvasmem.Push(originator.getDetails());
              Console.Clear();
              Console.WriteLine("Polyline translation added to canvas");
              Console.WriteLine("type done when finished");
            }
            else if (temp == "polygon")
            {
              string polygont = "";
              Console.WriteLine("Enter point 1");
              int p1 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter point 2");
              int p2 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter point 3");
              int p3 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter point 4");
              int p4 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter point 5");
              int p5 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter point 6");
              int p6 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter point 7");
              int p7 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter point 8");
              int p8 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter stroke (colour)");
              string stroke = Console.ReadLine();
              Console.WriteLine("Enter fill");
              string fill = Console.ReadLine();
              Console.WriteLine("Enter stroke-width(number)");
              int strokewidth = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter translate");
              string translate = Console.ReadLine();
              tempShape.polygont(p1, p2, p3, p4, p5, p6, p7, p8, stroke, strokewidth, fill, translate);
              tempshapes.AddFirst(tempShape); ;
              foreach (var item in tempshapes) { polygont += item.getPolygonT(); }
              originator.shapesClass = new ShapesClass(polygont);
              caretaker.addMemento(originator.createMemento());
              canvasmem.Push(originator.getDetails());
              Console.Clear();
              Console.WriteLine("Polygon translation added to canvas");
              Console.WriteLine("type done when finished");
            }
          }
          else if (sh == "rotate")
          {
            Console.WriteLine("What shape in the canvas do you want to rotate?");
            Console.WriteLine("Write shape:");
            string t = Console.ReadLine();
            string temp = t.ToLower();
            if (temp == "circle")
            {
              string circlesr = "";
              Console.WriteLine("Enter length");
              int x = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter width");
              int y = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter radius");
              int r = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter stroke (colour)");
              string stroke = Console.ReadLine();
              Console.WriteLine("Enter fill");
              string fill = Console.ReadLine();
              Console.WriteLine("Enter stroke-width(number)");
              int strokewidth = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter rotate");
              string rotate = Console.ReadLine();
              tempShape.circler(x, y, r, stroke, strokewidth, fill, rotate);
              tempshapes.AddFirst(tempShape);
              foreach (var item in tempshapes) { circlesr += item.getCircleR(); }
              //canvas.Add(circle);
              //using originator class to access the data from the memento class
              //through 
              originator.shapesClass = new ShapesClass(circlesr);
              caretaker.addMemento(originator.createMemento());
              canvasmem.Push(originator.getDetails());
              Console.Clear();
              Console.WriteLine("Circle rotation added to canvas");
              Console.WriteLine("type done when finished");
            }
            else if (temp == "rectangle")
            {
              string rectangler = "";
              Console.WriteLine("Enter x");
              int x = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter y");
              int y = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter width");
              int w = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter height");
              int h = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter stroke (colour)");
              string stroke = Console.ReadLine();
              Console.WriteLine("Enter fill");
              string fill = Console.ReadLine();
              Console.WriteLine("Enter stroke-width(number)");
              int strokewidth = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter rotation");
              string rotate = Console.ReadLine();
              tempShape.rectangler(x, y, w, h, stroke, strokewidth, fill, rotate);
              tempshapes.AddFirst(tempShape); ;
              foreach (var item in tempshapes) { rectangler += item.getRectangleR(); }
              //canvas.Add(rectangle);
              originator.shapesClass = new ShapesClass(rectangler);
              caretaker.addMemento(originator.createMemento());
              canvasmem.Push(originator.getDetails());
              Console.Clear();
              Console.WriteLine("Rectangle rotation added to canvas");
              Console.WriteLine("type done when finished");
            }
            else if (temp == "ellipse")
            {
              string ellipser = "";
              Console.WriteLine("Enter length");
              int x = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter width");
              int y = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter Radius X");
              int x2 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter Radius Y");
              int y2 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter stroke (colour)");
              string stroke = Console.ReadLine();
              Console.WriteLine("Enter fill");
              string fill = Console.ReadLine();
              Console.WriteLine("Enter stroke-width(number)");
              int strokewidth = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter Rotation");
              string rotate = Console.ReadLine();
              tempShape.ellipser(x, y, x2, y2, stroke, strokewidth, fill, rotate);
              tempshapes.AddFirst(tempShape); ;
              foreach (var item in tempshapes) { ellipser += item.getEllipseR(); }
              originator.shapesClass = new ShapesClass(ellipser);
              caretaker.addMemento(originator.createMemento());
              canvasmem.Push(originator.getDetails());
              Console.Clear();
              Console.WriteLine("Ellipse rotation added to canvas");
              Console.WriteLine("type done when finished");
            }
            else if (temp == "line")
            {
              string liner = "";
              Console.WriteLine("Enter X1");
              int x = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter Y1");
              int y = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter X2");
              int x2 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter Y2");
              int y2 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter stroke (colour)");
              string stroke = Console.ReadLine();
              Console.WriteLine("Enter fill");
              string fill = Console.ReadLine();
              Console.WriteLine("Enter stroke-width(number)");
              int strokewidth = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter rotation");
              string rotate = Console.ReadLine();
              tempShape.liner(x, y, x2, y2, stroke, strokewidth, fill, rotate);
              tempshapes.AddFirst(tempShape); ;
              foreach (var item in tempshapes) { liner += item.getLineR(); }
              originator.shapesClass = new ShapesClass(liner);
              caretaker.addMemento(originator.createMemento());
              canvasmem.Push(originator.getDetails());
              Console.Clear();
              Console.WriteLine("Line rotation added to canvas");
              Console.WriteLine("type done when finished");
            }
            else if (temp == "polyline")
            {
              string polyliner = "";
              Console.WriteLine("Enter point 1");
              int p1 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter point 2");
              int p2 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter point 3");
              int p3 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter point 4");
              int p4 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter point 5");
              int p5 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter point 6");
              int p6 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter point 7");
              int p7 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter point 8");
              int p8 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter stroke (colour)");
              string stroke = Console.ReadLine();
              Console.WriteLine("Enter fill");
              string fill = Console.ReadLine();
              Console.WriteLine("Enter stroke-width(number)");
              int strokewidth = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter rotation");
              string rotate = Console.ReadLine();
              tempShape.polyliner(p1, p2, p3, p4, p5, p6, p7, p8, stroke, strokewidth, fill, rotate);
              tempshapes.AddFirst(tempShape); ;
              foreach (var item in tempshapes) { polyliner += item.getPolylineR(); }
              originator.shapesClass = new ShapesClass(polyliner);
              caretaker.addMemento(originator.createMemento());
              canvasmem.Push(originator.getDetails());
              Console.Clear();
              Console.WriteLine("Polyline rotation added to canvas");
              Console.WriteLine("type done when finished");
            }
            else if (temp == "polygon")
            {
              string polygonr = "";
              Console.WriteLine("Enter point 1");
              int p1 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter point 2");
              int p2 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter point 3");
              int p3 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter point 4");
              int p4 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter point 5");
              int p5 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter point 6");
              int p6 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter point 7");
              int p7 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter point 8");
              int p8 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter stroke (colour)");
              string stroke = Console.ReadLine();
              Console.WriteLine("Enter fill");
              string fill = Console.ReadLine();
              Console.WriteLine("Enter stroke-width(number)");
              int strokewidth = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter rotaion");
              string rotate = Console.ReadLine();
              tempShape.polygonr(p1, p2, p3, p4, p5, p6, p7, p8, stroke, strokewidth, fill, rotate);
              tempshapes.AddFirst(tempShape); ;
              foreach (var item in tempshapes) { polygonr += item.getPolygonR(); }
              originator.shapesClass = new ShapesClass(polygonr);
              caretaker.addMemento(originator.createMemento());
              canvasmem.Push(originator.getDetails());
              Console.Clear();
              Console.WriteLine("Polygon rotation added to canvas");
              Console.WriteLine("type done when finished");
            }
            else
            {
              Console.WriteLine("Couldn't find shape");
              Console.WriteLine("Type done and try again");
            }
          }
          else if (sh == "skewing")
          {
            Console.WriteLine("What shape?");
            Console.WriteLine("Type shape:");
            string t = Console.ReadLine();
            string temp = t.ToLower();
            if (temp == "circle")
            {
              string circlesk = "";
              Console.WriteLine("Enter length");
              int x = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter width");
              int y = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter radius");
              int r = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter stroke (colour)");
              string stroke = Console.ReadLine();
              Console.WriteLine("Enter fill");
              string fill = Console.ReadLine();
              Console.WriteLine("Enter stroke-width(number)");
              int strokewidth = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter skew");
              string skew = Console.ReadLine();
              tempShape.circlesk(x, y, r, stroke, strokewidth, fill, skew);
              tempshapes.AddFirst(tempShape);
              foreach (var item in tempshapes) { circlesk += item.getCircleSK(); }
              originator.shapesClass = new ShapesClass(circlesk);
              caretaker.addMemento(originator.createMemento());
              canvasmem.Push(originator.getDetails());
              Console.Clear();
              Console.WriteLine("Circle skewing added to canvas");
              Console.WriteLine("type done when finished");
            }
            else if (temp == "rectangle")
            {
              string rectanglesk = "";
              Console.WriteLine("Enter x");
              int x = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter y");
              int y = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter width");
              int w = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter height");
              int h = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter stroke (colour)");
              string stroke = Console.ReadLine();
              Console.WriteLine("Enter fill");
              string fill = Console.ReadLine();
              Console.WriteLine("Enter stroke-width(number)");
              int strokewidth = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter skew");
              string skew = Console.ReadLine();
              tempShape.rectanglesk(x, y, w, h, stroke, strokewidth, fill, skew);
              tempshapes.AddFirst(tempShape); ;
              foreach (var item in tempshapes) { rectanglesk += item.getRectangleSK(); }
              //canvas.Add(rectangle);
              originator.shapesClass = new ShapesClass(rectanglesk);
              caretaker.addMemento(originator.createMemento());
              canvasmem.Push(originator.getDetails());
              Console.Clear();
              Console.WriteLine("Rectangle skewing added to canvas");
              Console.WriteLine("type done when finished");
            }
            else if (temp == "ellipse")
            {
              string ellipsesk = "";
              Console.WriteLine("Enter length");
              int x = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter width");
              int y = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter Radius X");
              int x2 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter Radius Y");
              int y2 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter stroke (colour)");
              string stroke = Console.ReadLine();
              Console.WriteLine("Enter fill");
              string fill = Console.ReadLine();
              Console.WriteLine("Enter stroke-width(number)");
              int strokewidth = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter skew");
              string skew = Console.ReadLine();
              tempShape.ellipsesk(x, y, x2, y2, stroke, strokewidth, fill, skew);
              tempshapes.AddFirst(tempShape); ;
              foreach (var item in tempshapes) { ellipsesk += item.getEllipseSK(); }
              originator.shapesClass = new ShapesClass(ellipsesk);
              caretaker.addMemento(originator.createMemento());
              canvasmem.Push(originator.getDetails());
              Console.Clear();
              Console.WriteLine("Ellipse skewing added to canvas");
              Console.WriteLine("type done when finished");
            }
            else if (temp == "line")
            {
              string linesk = "";
              Console.WriteLine("Enter X1");
              int x = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter Y1");
              int y = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter X2");
              int x2 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter Y2");
              int y2 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter stroke (colour)");
              string stroke = Console.ReadLine();
              Console.WriteLine("Enter fill");
              string fill = Console.ReadLine();
              Console.WriteLine("Enter stroke-width(number)");
              int strokewidth = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter skew");
              string skew = Console.ReadLine();
              tempShape.linesk(x, y, x2, y2, stroke, strokewidth, fill, skew);
              tempshapes.AddFirst(tempShape); ;
              foreach (var item in tempshapes) { linesk += item.getLineSK(); }
              originator.shapesClass = new ShapesClass(linesk);
              caretaker.addMemento(originator.createMemento());
              canvasmem.Push(originator.getDetails());
              Console.Clear();
              Console.WriteLine("Line skewing added to canvas");
              Console.WriteLine("type done when finished");
            }
            else if (temp == "polyline")
            {
              string polylinesk = "";
              Console.WriteLine("Enter point 1");
              int p1 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter point 2");
              int p2 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter point 3");
              int p3 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter point 4");
              int p4 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter point 5");
              int p5 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter point 6");
              int p6 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter point 7");
              int p7 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter point 8");
              int p8 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter stroke (colour)");
              string stroke = Console.ReadLine();
              Console.WriteLine("Enter fill");
              string fill = Console.ReadLine();
              Console.WriteLine("Enter stroke-width(number)");
              int strokewidth = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter skew");
              string skew = Console.ReadLine();
              tempShape.polylinesk(p1, p2, p3, p4, p5, p6, p7, p8, stroke, strokewidth, fill, skew);
              tempshapes.AddFirst(tempShape); ;
              foreach (var item in tempshapes) { polylinesk += item.getPolylineSK(); }
              originator.shapesClass = new ShapesClass(polylinesk);
              caretaker.addMemento(originator.createMemento());
              canvasmem.Push(originator.getDetails());
              Console.Clear();
              Console.WriteLine("Polyline skew added to canvas");
              Console.WriteLine("type done when finished");
            }
            else if (temp == "polygon")
            {
              string polygonsk = "";
              Console.WriteLine("Enter point 1");
              int p1 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter point 2");
              int p2 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter point 3");
              int p3 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter point 4");
              int p4 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter point 5");
              int p5 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter point 6");
              int p6 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter point 7");
              int p7 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter point 8");
              int p8 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter stroke (colour)");
              string stroke = Console.ReadLine();
              Console.WriteLine("Enter fill");
              string fill = Console.ReadLine();
              Console.WriteLine("Enter stroke-width(number)");
              int strokewidth = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter skew");
              string skew = Console.ReadLine();
              tempShape.polygonsk(p1, p2, p3, p4, p5, p6, p7, p8, stroke, strokewidth, fill, skew);
              tempshapes.AddFirst(tempShape); ;
              foreach (var item in tempshapes) { polygonsk += item.getPolygonSK(); }
              originator.shapesClass = new ShapesClass(polygonsk);
              caretaker.addMemento(originator.createMemento());
              canvasmem.Push(originator.getDetails());
              Console.Clear();
              Console.WriteLine("Polygon skewing added to canvas");
              Console.WriteLine("type done when finished");
            }
            else
            {
              Console.WriteLine("Couldn't find shape");
              Console.WriteLine("Type done and try again");
            }
          }
          else if (sh == "scale")
          {
            Console.WriteLine("What shape would you like to add scale to?");
            Console.WriteLine("Type shape:");
            string t = Console.ReadLine();
            string temp = t.ToLower();
            if (temp == "circle")
            {
              string circles = "";
              Console.WriteLine("Enter length");
              int x = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter width");
              int y = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter radius");
              int r = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter stroke (colour)");
              string stroke = Console.ReadLine();
              Console.WriteLine("Enter fill");
              string fill = Console.ReadLine();
              Console.WriteLine("Enter stroke-width(number)");
              int strokewidth = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter scale");
              string scale = Console.ReadLine();
              tempShape.circles(x, y, r, stroke, strokewidth, fill, scale);
              tempshapes.AddFirst(tempShape);
              foreach (var item in tempshapes) { circles += item.getCircleS(); }
              originator.shapesClass = new ShapesClass(circles);
              caretaker.addMemento(originator.createMemento());
              canvasmem.Push(originator.getDetails());
              Console.Clear();
              Console.WriteLine("Circle scale added to canvas");
              Console.WriteLine("type done when finished");
            }
            else if (temp == "rectangle")
            {
              string rectangles = "";
              Console.WriteLine("Enter x");
              int x = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter y");
              int y = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter width");
              int w = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter height");
              int h = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter stroke (colour)");
              string stroke = Console.ReadLine();
              Console.WriteLine("Enter fill");
              string fill = Console.ReadLine();
              Console.WriteLine("Enter stroke-width(number)");
              int strokewidth = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter scale");
              string scale = Console.ReadLine();
              tempShape.rectangles(x, y, w, h, stroke, strokewidth, fill, scale);
              tempshapes.AddFirst(tempShape); ;
              foreach (var item in tempshapes) { rectangles += item.getRectangleS(); }
              originator.shapesClass = new ShapesClass(rectangles);
              caretaker.addMemento(originator.createMemento());
              canvasmem.Push(originator.getDetails());
              Console.Clear();
              Console.WriteLine("Rectangle scale added to canvas");
              Console.WriteLine("type done when finished");
            }
            else if (temp == "ellipse")
            {
              string ellipses = "";
              Console.WriteLine("Enter length");
              int x = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter width");
              int y = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter Radius X");
              int x2 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter Radius Y");
              int y2 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter stroke (colour)");
              string stroke = Console.ReadLine();
              Console.WriteLine("Enter fill");
              string fill = Console.ReadLine();
              Console.WriteLine("Enter stroke-width(number)");
              int strokewidth = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter scale");
              string scale = Console.ReadLine();
              tempShape.ellipses(x, y, x2, y2, stroke, strokewidth, fill, scale);
              tempshapes.AddFirst(tempShape); ;
              foreach (var item in tempshapes) { ellipses += item.getEllipseS(); }
              originator.shapesClass = new ShapesClass(ellipses);
              caretaker.addMemento(originator.createMemento());
              canvasmem.Push(originator.getDetails());
              Console.Clear();
              Console.WriteLine("Ellipse scale added to canvas");
              Console.WriteLine("type done when finished");
            }
            else if (temp == "line")
            {
              string lines = "";
              Console.WriteLine("Enter X1");
              int x = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter Y1");
              int y = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter X2");
              int x2 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter Y2");
              int y2 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter stroke (colour)");
              string stroke = Console.ReadLine();
              Console.WriteLine("Enter fill");
              string fill = Console.ReadLine();
              Console.WriteLine("Enter stroke-width(number)");
              int strokewidth = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter scale");
              string scale = Console.ReadLine();
              tempShape.lines(x, y, x2, y2, stroke, strokewidth, fill, scale);
              tempshapes.AddFirst(tempShape); ;
              foreach (var item in tempshapes) { lines += item.getLineS(); }
              originator.shapesClass = new ShapesClass(lines);
              caretaker.addMemento(originator.createMemento());
              canvasmem.Push(originator.getDetails());
              Console.Clear();
              Console.WriteLine("Line scale added to canvas");
              Console.WriteLine("type done when finished");
            }
            else if (temp == "polyline")
            {
              string polylines = "";
              Console.WriteLine("Enter point 1");
              int p1 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter point 2");
              int p2 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter point 3");
              int p3 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter point 4");
              int p4 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter point 5");
              int p5 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter point 6");
              int p6 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter point 7");
              int p7 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter point 8");
              int p8 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter stroke (colour)");
              string stroke = Console.ReadLine();
              Console.WriteLine("Enter fill");
              string fill = Console.ReadLine();
              Console.WriteLine("Enter stroke-width(number)");
              int strokewidth = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter scale");
              string scale = Console.ReadLine();
              tempShape.polylines(p1, p2, p3, p4, p5, p6, p7, p8, stroke, strokewidth, fill, scale);
              tempshapes.AddFirst(tempShape); ;
              foreach (var item in tempshapes) { polylines += item.getPolylineS(); }
              originator.shapesClass = new ShapesClass(polylines);
              caretaker.addMemento(originator.createMemento());
              canvasmem.Push(originator.getDetails());
              Console.Clear();
              Console.WriteLine("Polyline scale added to canvas");
              Console.WriteLine("type done when finished");
            }
            else if (temp == "polygon")
            {
              string polygons = "";
              Console.WriteLine("Enter point 1");
              int p1 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter point 2");
              int p2 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter point 3");
              int p3 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter point 4");
              int p4 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter point 5");
              int p5 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter point 6");
              int p6 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter point 7");
              int p7 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter point 8");
              int p8 = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter stroke (colour)");
              string stroke = Console.ReadLine();
              Console.WriteLine("Enter fill");
              string fill = Console.ReadLine();
              Console.WriteLine("Enter stroke-width(number)");
              int strokewidth = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine("Enter scale");
              string scale = Console.ReadLine();
              tempShape.polygons(p1, p2, p3, p4, p5, p6, p7, p8, stroke, strokewidth, fill, scale);
              tempshapes.AddFirst(tempShape); ;
              foreach (var item in tempshapes) { polygons += item.getPolygonS(); }
              originator.shapesClass = new ShapesClass(polygons);
              caretaker.addMemento(originator.createMemento());
              canvasmem.Push(originator.getDetails());
              Console.Clear();
              Console.WriteLine("Polygon scale added to canvas");
              Console.WriteLine("type done when finished");
            }
            else
            {
              Console.WriteLine("Couldn't find shape");
              Console.WriteLine("Type done and try again");
            }
          }
          else if (sh == "done")
          {
            edit = true;
            printHelp();
          }
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
        //canvas.Clear();
        canvasmem.Clear();
        //Readd the start of the svg file
        //canvas.Add("<svg viewBox=\"0 0 400 200\" xmlns=\"http://www.w3.org/2000/svg\">");
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
        caretaker.undoMemento(canvasmem);
      }
      else if (inpletundercase == "R")
      {
        //Redo
        caretaker.redoMemento(canvasmem);
      }
      else if (inpletundercase == "D")
      {
        //Display Canvas
        //foreach (String s in canvasmem) { Console.WriteLine(s); }
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
  static void printHelp()
  {
    Console.WriteLine("A Add <shape> to canvas");
    Console.WriteLine("S Save current canvas to file");
    Console.WriteLine("D Display current canvas");
    Console.WriteLine("U Undo last operation");
    Console.WriteLine("R Redo last operation");
    Console.WriteLine("T add manipulation to canvas");
    Console.WriteLine("C Clear canvas");
    Console.WriteLine("Q Quit application");
  }
  static void printCommands()
  {
    Console.WriteLine("Commands:");
    Console.WriteLine("A,T,S,D,U,R,C,Q");
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


  //Method to print stack correctly
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

}
