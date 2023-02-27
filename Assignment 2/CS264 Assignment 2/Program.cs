namespace Assignment2;

public class Shape
{
  private int cx;
  private int cy;
  private int r;
  private string fill1;
  private string stroke1;
  private int wX;
  private int wY;
  private int width;
  private int height;
  private string fill2;
  private string stroke2;
  private int ecx;
  private int ecy;
  private int rx;
  private int ry;
  private string fill3;
  private string stroke3;

  private int lx1;
  private int lx2;
  private int ly1;
  private int ly2;
  private int lstroke;

  private string stroke4;

  private int p1;
  private int p2;
  private int p3;
  private int p4;
  private int p5;
  private int p6;
  private int p7;
  private int p8;
  private int pg1;
  private int pg2;
  private int pg3;
  private int pg4;
  private int pg5;
  private int pg6;
  private int pg7;
  private int pg8;
  private int pathd1;
  private int pathd2;
  private int index;
  private string name;
  private int strokeWidth = 5;
  public void circle(string name,int cx, int cy, int r, string fill1, string stroke1, int i)
    {
      this.cx = cx;
      this.cy = cy;
      this.r = r;
      this.stroke1 = "black";
      this.fill1 = "grey";
      this.index = i;
      this.name = name;
    }
  
  public void rectangle(string name,int wX, int wY, int width, int height, string fill2, string stroke2, int i)
    {
      this.wX = wX;
      this.wY = wY;
      this.width = width;
      this.height = height;
      this.fill2 = fill2;
      this.stroke2 = stroke2;
      this.index = i;
      this.name = name;
    }
  
  public void ellipse(string name,int ecx, int ecy, int rx, int ry, string fill3, string stroke3, int i)
    {
      this.ecx = ecx;
      this.ecy = ecy;
      this.rx = rx;
      this.ry = ry;
      this.fill3 = fill3;
      this.stroke3 = stroke3;
      this.index = i;
      this.name = name;
    }

  public void line(string name,int lx1, int ly1, int lx2, int ly2, int lstroke, string stroke4, int i)
    {
      this.lx1 = lx1;
      this.ly1 = ly1;
      this.lx2 = lx2;
      this.ly2 = ly2;
      this.lstroke = lstroke;
      this.stroke4 = stroke4;
      this.index = i;
      this.name = name;
    }

  public void polyline(string name,int p1, int p2, int p3, int p4, int p5, int p6, int p7, int p8, int i)
    {
      this.p1 = p1;
      this.p2 = p2;
      this.p3 = p3;
      this.p4 = p4;
      this.p5 = p5;
      this.p6 = p6;
      this.p7 = p7;
      this.p8 = p8;
      this.index = i;
      this.name = name;
    }

  public void polygon(string name,int pg1, int pg2, int pg3, int pg4, int pg5, int pg6, int pg7, int pg8, int i)
    {
      this.pg1 = pg1;
      this.pg2 = pg2;
      this.pg3 = pg3;
      this.pg4 = p4;
      this.pg5 = pg5;
      this.pg6 = pg6;
      this.pg7 = pg7;
      this.pg8 = pg8;
      this.index = i;
      this.name = name;
    }
  public void path(string name,int pathd1, int pathd2, int i)
    {
      this.pathd1 = pathd1;
      this.pathd2 = pathd2;
      this.index = i;
      this.name = name;
    }

        //my setters
        //int cx, int cy, int r, string fill1, string stroke1
        //int wX, int wY, int width, int height, string fill2, string stroke2
        
        public void setName(String n) { this.name = n; }
        //fill and strokes are the same
        public void setfill(String n) { this.fill1 = n; }
        public void setstroke(String n) { this.stroke1 = n; }
        public void setStrokeWidth(int i) { this.strokeWidth = i; }
        public void setIndex(int i) { this.index = i; }
        public void setcx(int x) { this.cx = x; }
        public void setcy(int y) { this.cy = y; }
        public void setr(int x) { this.r = x; }
        public void setwX(int y) { this.wX = y; }
        public void setwY(int r) { this.wY = r; }
        public void setwidth(int x) { this.width = x; }
        public void setheight(int w) { this.height = w; }
        //int ecx, int ecy, int rx, int ry, string fill3, string stroke3
        //int lx1, int ly1, int lx2, int ly2, int lstroke, string stroke4,
        //int p1, int p2, int p3, int p4, int p5, int p6, int p7, int p8,
        public void setecx(int w) { this.ecx = w; }
        public void setecy(int w) { this.ecy = w; }
        public void setrx(int w) { this.rx = w; }
        public void setry(int w) { this.ry = w; }
        public void setlx1(int w) { this.lx1 = w; }
        public void setlx2(int w) { this.lx2 = w; }
        public void setly1(int w) { this.ly1 = w; }
        public void setly2(int w) { this.ly2 = w; }
        public void setp1(int w) { this.p1 = w; }
        public void setp2(int w) { this.p2 = w; }
        public void setp3(int w) { this.p3 = w; }
        public void setp4(int w) { this.p4 = w; }
        public void setp5(int w) { this.p5 = w; }
        public void setp6(int w) { this.p6 = w; }
        public void setp7(int w) { this.p7 = w; }
        public void setp8(int w) { this.p8 = w; }
        //int pg1, int pg2, int pg3, int pg4, int pg5, int pg6, int pg7, int pg8,
        //int pathd1, int pathd2,
        public void setpg1(int w) { this.pg1 = w; }
        public void setpg2(int w) { this.pg2 = w; }
        public void setpg3(int w) { this.pg3 = w; }
        public void setpg4(int w) { this.pg4 = w; }
        public void setpg5(int w) { this.pg5 = w; }
        public void setpg6(int w) { this.pg6 = w; }
        public void setpg7(int w) { this.pg7 = w; }
        public void setpg8(int w) { this.pg8 = w; }
        public void setpathd1(int w) { this.pathd1 = w; }
        public void setpathd2(int w) { this.pathd2 = w; }
        public int getIndex() { return this.index; }
        public string getName() { return this.name; }
    public void getShape()
    {
      Console.WriteLine("Index: " + this.index + ", Name: " + this.name);
    }

            public string getRectangle()
        {
            return "    <rect x=\"" + this.wX +"px"+ "\" y=\"" + this.wY +"px"+ "\" width=\"" + this.width +"px"+ "\" height=\"" + this.height +"px"+ "\" fill=\"" + this.fill2 + "\" stroke=\"" + this.stroke2 + "\" stroke-width=\"" +this.strokeWidth+"px"+ "\"/>";
        }
        public string getCircle()
        {
            return "    <circle cx=\"" + this.cx +"px"+ "\" cy=\"" + this.cy +"px"+ "\" r=\"" + this.r +"px"+ "\" fill=\"" + this.fill1 + "\" stroke=\"" + this.stroke1 + "\" stroke-width=\"" +this.strokeWidth+"px"+ "\"/>";
        }
        public string getEllipse()
        {
            return "    <ellipse cx= \""+this.ecx+"px\""+" cy= \""+this.ecy+"px\" "+"rx= \""+this.rx+"px\" "+"ry= \""+this.ry+"px\" "+"style="+"\"fill:"+this.fill3+"\""+" stroke-width=\"" + this.strokeWidth +"px"+"\""+" />";
        }
        public string getLine()
        {
            return "    <line x1= \""+this.lx1+"px\" "+"y1= \""+this.ly1+"px\" "+"x2= \""+this.lx2+"px\" "+"y2= \""+this.ly2+"px\" "+"stroke= "+"\""+this.stroke4+"\" "+"stroke-width= "+"\""+this.lstroke+"px\" "+"/>";
        }
        public string getPolyline()
        {
            return "    <polyline points="+"\""+this.p1+","+this.p2+" "+this.p3+","+this.p4+" "+this.p5+","+this.p6+" "+this.p7+","+this.p8+"\""+" stroke-width=\"" + this.strokeWidth +"\""+" />";
        }
        public string getPolygon()
        {
            return "    <polygon points="+"\""+this.pg1+","+this.pg2+" "+this.pg3+","+this.pg4+" "+this.pg5+","+this.pg6+" "+this.pg7+","+this.pg8+"\""+" stroke-width=\"" + this.strokeWidth +"\""+" />";
        }
        public string getPath()
        {
            return "    <path d="+"\"M"+pathd1+" "+pathd2+"\""+" stroke-width=\"" + this.strokeWidth +"\""+"/>";
        }
}
public static class canvas
{

  public static void Main(String []args) {
      LinkedList<Shape> shapes = new LinkedList<Shape>();
      Random rnd = new Random();
      int num = rnd.Next(100);
      int ind = 1;
      string svg = "";
      Console.Clear();
      Console.WriteLine("Welcome to My SVG CANVAS UI DEMO");
      Console.WriteLine("==================================");
      Console.WriteLine("\n \nChoose your option;");
      //On select user will be given options to select the shape they want
      Console.WriteLine("\n1)Add Shape");
      //On select user will be given other options for editing the shapes 
      //and it's attributes
      Console.WriteLine("2)Delete/Edit Shapes");
      //Delete shape
      //Show the shapes you selected as SVG
      Console.WriteLine("3)Save and View");
      //Exit Canvas
      Console.WriteLine("4)Quit!");

      bool run = true;
    
    while(run ==true)  
      {
        Shape newshape = new Shape();
        Shape tempShape = new Shape();
        string input = Console.ReadLine();
        int var = Convert.ToInt32(input);
          switch(var)
          {
            case 1:
//==================================================Start of Case 1=============================================
              Console.Clear();
              Console.WriteLine("You chose option 1");
              Console.WriteLine("Choose what shape you want!");
              Console.WriteLine("Circle");
              Console.WriteLine("Rectangle");              
              Console.WriteLine("Ellipse");              
              Console.WriteLine("Line");              
              Console.WriteLine("Polyline");              
              Console.WriteLine("Polygon");              
              Console.WriteLine("Path");              
              string inp1 = Console.ReadLine();
              string input1 = inp1.ToLower();
              switch(input1)
              {
                case "circle":
            //================================Start of case a==============================================
                  Console.Clear();
                  Console.WriteLine("Circle");
                  Console.WriteLine("Enter length");
                  int cx = Convert.ToInt32(Console.ReadLine());
                  Console.WriteLine("Enter width");
                  int cy = Convert.ToInt32(Console.ReadLine());
                  Console.WriteLine("Enter radius");
                  int r = Convert.ToInt32(Console.ReadLine());
                  string fill1 = "red";
                  string stroke1 = "yellow";
                  //newshape.circle(cx,cy,r,fill1,stroke1);
                  //shapes.AddFirst(newshape);
                  tempShape.circle(input1,cx,cy,r,fill1,stroke1,ind++);
                  shapes.AddFirst(tempShape);
                  printHome();
                  break;
            //================================End of case a==============================================
                //Rectangle Option
                case "rectangle":
  //================================================== Start of case b ==============================
                  Console.Clear();
                  Console.WriteLine("Rectangle");
                  //Shape rect = new Rectangle();
                  Console.WriteLine("Enter x");
                  int wX = Convert.ToInt32(Console.ReadLine());
                  Console.WriteLine("Enter y");
                  int wY = Convert.ToInt32(Console.ReadLine());
                  Console.WriteLine("Enter width");
                  int width = Convert.ToInt32(Console.ReadLine());
                  Console.WriteLine("Enter height");
                  int height = Convert.ToInt32(Console.ReadLine());
                  string fill2 = "red";
                  string stroke2 = "yellow";
                  tempShape.rectangle(input1,wX,wY,width,height,fill2,stroke2,ind++);
                  shapes.AddFirst(tempShape);
                  printHome();
                  break;
      //================================End of case b==============================================
                case "ellipse":
  //============================================== Start of case c ==============================
                  Console.Clear();
                  Console.WriteLine("Ellipse");
                  //Shape ellipse = new Ellipse();
                  Console.WriteLine("Enter length");
                  int ecx = Convert.ToInt32(Console.ReadLine());
                  Console.WriteLine("Enter width");
                  int ecy = Convert.ToInt32(Console.ReadLine());
                  Console.WriteLine("Enter Radius X");
                  int rx = Convert.ToInt32(Console.ReadLine());
                  Console.WriteLine("Enter Radius Y");
                  int ry = Convert.ToInt32(Console.ReadLine());
                  string fill3 = "red";
                  string stroke3 = "yellow";
                  tempShape.ellipse(input1,ecx,ecy,rx,ry,fill3,stroke3,ind++);
                  shapes.AddFirst(tempShape);
                  printHome();
                  break;
  //=============================End of Case c ==========================================
                  case "line":
  //===============================Start of case d=============================================================
                  Console.Clear();
                  Console.WriteLine("Line");
                  //Shape line = new Line();
                  Console.WriteLine("Enter X1");
                  int lx1 = Convert.ToInt32(Console.ReadLine());
                  Console.WriteLine("Enter Y1");
                  int ly1 = Convert.ToInt32(Console.ReadLine());
                  Console.WriteLine("Enter X2");
                  int lx2 = Convert.ToInt32(Console.ReadLine());
                  Console.WriteLine("Enter Y2");
                  int ly2 = Convert.ToInt32(Console.ReadLine());
                  Console.WriteLine("Enter Stroke width");
                  int lstroke = Convert.ToInt32(Console.ReadLine());
                  string stroke4 = "black";
                  tempShape.line(input1,lx1,ly1,lx2,ly2,lstroke,stroke4,ind++);
                  shapes.AddFirst(tempShape);
                  printHome();
                  break;
  //=================================End of case d==========================================================
                    case "polyline":
  //======================================Start of case e======================================================
                  Console.Clear();
                  Console.WriteLine("Polyline");
                  //Shape polyline = new Polyline();
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
                  tempShape.polyline(input1,p1,p2,p3,p4,p5,p6,p7,p8,ind++);
                  shapes.AddFirst(tempShape);
                  printHome();
                  break;
  //======================================End of case e======================================================
                      case "polygon":
  //======================================Start of case f======================================================
                  Console.Clear();
                  Console.WriteLine("Polygon");
                  //Shape polygon = new Polygon();
                  Console.WriteLine("Enter point 1");
                  int pg1 = Convert.ToInt32(Console.ReadLine());
                  Console.WriteLine("Enter point 2");
                  int pg2 = Convert.ToInt32(Console.ReadLine());
                  Console.WriteLine("Enter point 3");
                  int pg3 = Convert.ToInt32(Console.ReadLine());
                  Console.WriteLine("Enter point 4");
                  int pg4 = Convert.ToInt32(Console.ReadLine());
                  Console.WriteLine("Enter point 5");
                  int pg5 = Convert.ToInt32(Console.ReadLine());
                  Console.WriteLine("Enter point 6");
                  int pg6 = Convert.ToInt32(Console.ReadLine());
                  Console.WriteLine("Enter point 7");
                  int pg7 = Convert.ToInt32(Console.ReadLine());
                  Console.WriteLine("Enter point 8");
                  int pg8 = Convert.ToInt32(Console.ReadLine());
                  tempShape.polygon(input1,pg1,pg2,pg3,pg4,pg5,pg6,pg7,pg8,ind++);
                  shapes.AddFirst(tempShape);
                  printHome();
                  break;
  //======================================End of case f======================================================
                      case "path":
  //======================================Start of case g======================================================
                  Console.Clear();
                  Console.WriteLine("Path");
                  //Shape path = new Path();
                  Console.WriteLine("Enter your X coordinate");
                  int pathd1 = Convert.ToInt32(Console.ReadLine());
                  Console.WriteLine("Enter your Y coordinate");
                  int pathd2 = Convert.ToInt32(Console.ReadLine());
                  tempShape.path(input1,pathd1,pathd2,ind++);
                  shapes.AddFirst(tempShape);
                  printHome();
                  break;
  //======================================End of case g======================================================
              }
//==================================================End of Case 1=============================================
              break;
            case 2:
                //Delete and Edit
              run = true;
                //create loop to continously ask user to update or delete shapes
                //stop loop if user is finished
                while (run)
                {
                    Console.WriteLine("What would you like to edit or delete?\nSelect Index: ");
                    foreach (Shape s in shapes) { s.getShape(); }
                    int index = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("a = Delete\nb = Update");
                    string input3 = Console.ReadLine();
                    if (input3.Equals("a") || input3.Equals("A")) { deleteShape(shapes, index); }
                    else { updateList(shapes, index); }
                    svg = createSVG(shapes);
                    Console.WriteLine("Press Enter to save and exit or 1 to edit a different shape");
                    //sometimes editing multiple shapes messes up so just restart and select 
                    //the shape that messed up and you can edit and delete , thanks!b
                    if (String.IsNullOrEmpty(Console.ReadLine())) 
                    { 
                      svg = createSVG(shapes);
                      //creates separate files every game
                      run = false; File.WriteAllText("shapes"+num+".svg", svg);
                      Console.WriteLine("Your SVG File: " + "\n" + svg + "\nYour SVG file is saved as shapes"+num+".svg"); 
                    }
                    else
                    {
                      svg = createSVG(shapes);
                    }
                }
                    break;
            case 3:
              //Save and View
              Console.WriteLine("You chose option 3");
              svg = createSVG(shapes);
              //creates separate files every game
              File.WriteAllText("shapes"+num+".svg", svg);
              Console.WriteLine("Your SVG File: " + "\n" + svg + "\nYour SVG file is saved as shapes"+num+".svg");
              Console.WriteLine("PRESS 2 TO EDIT!!");
              break;
              run = false;
            case 4:
              //Quit
              Console.WriteLine("You Quit!");
              Console.WriteLine("Goodbye!");
              run = false;
              break;
            default:
              Console.WriteLine("Incorrect input");
              break;
          }
      }
  }

  public static string createSVG(LinkedList<Shape> shape)
        {
            string start = "<svg width=\"300\" height=\"300\" version=\"1.1\" xmlns=\"http://www.w3.org/2000/svg\">";
            string middle = "";
            string end = "</svg>";
            foreach (Shape s in shape)
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

          public static void deleteShape(LinkedList<Shape> shape, int index)
        {
            Shape temp = new Shape();
            foreach (Shape s in shape)
            {
                if (index == s.getIndex()) { temp = s; }
            }
            shape.Remove(temp);
        }
  static void printHome()
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

          public static void updateList(LinkedList<Shape> shape, int index)
        {
            foreach (Shape s in shape)
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