namespace Assignment5;

public class ShapeA2
{
  private int cx;
  private int cy;
  private int r;
  private string fill;
  private string stroke;
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
  public void circle(string name, int cx, int cy, int r, string fill1, string stroke1,int i)
  {
    this.cx = cx;
    this.cy = cy;
    this.r = r;
    this.stroke1 = "black";
    this.fill1 = "grey";
    this.index = i;
    this.name = name;
  }

  public void rectangle(string name, int wX, int wY, int width, int height, string fill2, string stroke2, int i)
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

  public void ellipse(string name, int ecx, int ecy, int rx, int ry, string fill3, string stroke3, int i)
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

  public void line(string name, int lx1, int ly1, int lx2, int ly2, int lstroke, string stroke4, int i)
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

  public void polyline(string name, int p1, int p2, int p3, int p4, int p5, int p6, int p7, int p8, int i)
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

  public void polygon(string name, int pg1, int pg2, int pg3, int pg4, int pg5, int pg6, int pg7, int pg8, int i)
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
  public void path(string name, int pathd1, int pathd2, int i)
  {
    this.pathd1 = pathd1;
    this.pathd2 = pathd2;
    this.index = i;
    this.name = name;
  }

  public void style(string stroke, string fill,string name)
  {
    this.stroke = stroke;
    this.fill = fill;
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
    return "    <rect x=\"" + this.wX + "px" + "\" y=\"" + this.wY + "px" + "\" width=\"" + this.width + "px" + "\" height=\"" + this.height + "px" + "\" fill=\"" + this.fill2 + "\" stroke=\"" + this.stroke2 + "\" stroke-width=\"" + this.strokeWidth + "px" + "\"/>";
  }
  public string getCircle()
  {
    return "    <circle cx=\"" + this.cx + "px" + "\" cy=\"" + this.cy + "px" + "\" r=\"" + this.r + "px" + "\" fill=\"" + this.fill1 + "\" stroke=\"" + this.stroke1 + "\" stroke-width=\"" + this.strokeWidth + "px" + "\"/>";
  }
  public string getEllipse()
  {
    return "    <ellipse cx= \"" + this.ecx + "px\"" + " cy= \"" + this.ecy + "px\" " + "rx= \"" + this.rx + "px\" " + "ry= \"" + this.ry + "px\" " + "style=" + "\"fill:" + this.fill3 + "\"" + " stroke-width=\"" + this.strokeWidth + "px" + "\"" + " />";
  }
  public string getLine()
  {
    return "    <line x1= \"" + this.lx1 + "px\" " + "y1= \"" + this.ly1 + "px\" " + "x2= \"" + this.lx2 + "px\" " + "y2= \"" + this.ly2 + "px\" " + "stroke= " + "\"" + this.stroke4 + "\" " + "stroke-width= " + "\"" + this.lstroke + "px\" " + "/>";
  }
  public string getPolyline()
  {
    return "    <polyline points=" + "\"" + this.p1 + "," + this.p2 + " " + this.p3 + "," + this.p4 + " " + this.p5 + "," + this.p6 + " " + this.p7 + "," + this.p8 + "\"" + " stroke-width=\"" + this.strokeWidth + "\"" + " />";
  }
  public string getPolygon()
  {
    return "    <polygon points=" + "\"" + this.pg1 + "," + this.pg2 + " " + this.pg3 + "," + this.pg4 + " " + this.pg5 + "," + this.pg6 + " " + this.pg7 + "," + this.pg8 + "\"" + " stroke-width=\"" + this.strokeWidth + "\"" + " />";
  }
  public string getPath()
  {
    return "    <path d=" + "\"M" + pathd1 + " " + pathd2 + "\"" + " stroke-width=\"" + this.strokeWidth + "\"" + "/>";
  }

  public string nCircle()
  {
    return "  <circle cx=\"50\" cy=\"50\" r=\"50\" stroke="+"\""+this.stroke+"\""+ "stroke-width=\"3\" fill= "+"\""+this.fill+"\""+" />";
  }
  public string nRectangle()
  {
    return "  <rect width=\"100\" height=\"100\" style=\"fill: "+"\""+this.fill+"\""+";stroke-width:3;stroke: "+"\""+this.stroke+"\""+ " />";
  }
  public string nEllipse()
  {
    return "  <ellipse cx=\"100\" cy=\"50\" rx=\"100\" ry=\"50\" style=\"fill:"+"\""+this.fill+"\""+";stroke:"+"\""+this.stroke+"\""+";stroke-width:2\" />";
  }
  public string nLine()
  {
    return "  <line x1=\"0\" y1=\"80\" x2=\"100\" y2=\"20\" stroke= "+"\""+this.stroke+"\""+" />";
  }
  public string nPolyline()
  {
    return "  <polyline points=\"100,100 150,25 150,75 200,0\" fill= "+"\""+this.fill+"\""+" stroke= "+"\""+this.stroke+"\""+" />";
  }
  public string nPolygon()
  {
    return "  <polygon points=\"100,100 150,25 150,75 200,0\" fill= "+"\""+this.fill+"\""+" stroke= "+"\""+this.stroke+"\""+" />";
  }
  public string nPath()
  {
    return "<path d=\"M10 10\"/>";
  }
}