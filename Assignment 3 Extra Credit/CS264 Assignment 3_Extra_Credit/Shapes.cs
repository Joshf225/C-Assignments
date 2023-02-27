namespace Assignment3;

public class Shape
{
  private int r;
  private int x;
  private int y;
  private int w;
  private int h;
  private int rx;
  private int ry;
  private int x2;
  private int y2;
  private int p1;
  private int p2;
  private int p3;
  private int p4;
  private int p5;
  private int p6;
  private int p7;
  private int p8;
  private string stroke = "";
  private int strokewidth ;
  private string fill = "";
  private string translate = "";
  private string scale = "";
  private string rotate = "";
  private string skew = "";

  public void circle(int x, int y, int r,string stroke,int strokewidth, string fill)
  {
    this.x = x;
    this.y = y;
    this.r = r;
    this.stroke = stroke;
    this.fill = fill;
    this.strokewidth = strokewidth;
  }
  public void rectangle(int x, int y, int w, int h,string stroke,int strokewidth, string fill)
  {
    this.w = w;
    this.h = h;
    this.x = x;
    this.y = y;
    this.stroke = stroke;
    this.fill = fill;
    this.strokewidth = strokewidth;
  }
  public void ellipse(int x, int y, int rx, int ry,string stroke,int strokewidth, string fill)
  {
    this.x = x;
    this.y = y;
    this.rx = rx;
    this.ry = ry;
    this.stroke = stroke;
    this.fill = fill;
    this.strokewidth = strokewidth;
  }
  public void line(int x, int y, int x2, int y2,string stroke,int strokewidth, string fill)
  {
    this.x = x;
    this.y = y;
    this.x2 = x2;
    this.y2 = y2;
    this.stroke = stroke;
    this.fill = fill;
    this.strokewidth = strokewidth;
  }
  public void polyline(int p1, int p2, int p3, int p4, int p5, int p6, int p7, int p8,string stroke,int strokewidth, string fill)
  {
    this.p1 = p1;
    this.p2 = p2;
    this.p3 = p3;
    this.p4 = p4;
    this.p5 = p5;
    this.p6 = p6;
    this.p7 = p7;
    this.p8 = p8;
    this.stroke = stroke;
    this.fill = fill;
    this.strokewidth = strokewidth;
  }
  public void polygon(int p1, int p2, int p3, int p4, int p5, int p6, int p7, int p8,string stroke,int strokewidth, string fill)
  {
    this.p1 = p1;
    this.p2 = p2;
    this.p3 = p3;
    this.p4 = p4;
    this.p5 = p5;
    this.p6 = p6;
    this.p7 = p7;
    this.p8 = p8;
    this.stroke = stroke;
    this.fill = fill;
    this.strokewidth = strokewidth;
  }
  public void circlet(int x, int y, int r,string stroke,int strokewidth, string fill,string translate)
  {
    this.x = x;
    this.y = y;
    this.r = r;
    this.stroke = stroke;
    this.fill = fill;
    this.strokewidth = strokewidth;
    this.translate = translate;
  }
  public void rectanglet(int x, int y, int w, int h,string stroke,int strokewidth, string fill, string translate)
  {
    this.w = w;
    this.h = h;
    this.x = x;
    this.y = y;
    this.stroke = stroke;
    this.fill = fill;
    this.strokewidth = strokewidth;
    this.translate = translate;
  }
  public void ellipset(int x, int y, int rx, int ry,string stroke,int strokewidth, string fill, string translate)
  {
    this.x = x;
    this.y = y;
    this.rx = rx;
    this.ry = ry;
    this.stroke = stroke;
    this.fill = fill;
    this.strokewidth = strokewidth;
    this.translate = translate;
  }
  public void linet(int x, int y, int x2, int y2,string stroke,int strokewidth, string fill, string translate)
  {
    this.x = x;
    this.y = y;
    this.x2 = x2;
    this.y2 = y2;
    this.stroke = stroke;
    this.fill = fill;
    this.strokewidth = strokewidth;
    this.translate = translate;
  }
  public void polylinet(int p1, int p2, int p3, int p4, int p5, int p6, int p7, int p8,string stroke,int strokewidth, string fill, string translate)
  {
    this.p1 = p1;
    this.p2 = p2;
    this.p3 = p3;
    this.p4 = p4;
    this.p5 = p5;
    this.p6 = p6;
    this.p7 = p7;
    this.p8 = p8;
    this.stroke = stroke;
    this.fill = fill;
    this.strokewidth = strokewidth;
    this.translate = translate;
  }
  public void polygont(int p1, int p2, int p3, int p4, int p5, int p6, int p7, int p8,string stroke,int strokewidth, string fill, string translate)
  {
    this.p1 = p1;
    this.p2 = p2;
    this.p3 = p3;
    this.p4 = p4;
    this.p5 = p5;
    this.p6 = p6;
    this.p7 = p7;
    this.p8 = p8;
    this.stroke = stroke;
    this.fill = fill;
    this.strokewidth = strokewidth;
    this.translate = translate;
  }
  public void circles(int x, int y, int r,string stroke,int strokewidth, string fill,string scale)
  {
    this.x = x;
    this.y = y;
    this.r = r;
    this.stroke = stroke;
    this.fill = fill;
    this.strokewidth = strokewidth;
    this.scale = scale;
  }
  public void rectangles(int x, int y, int w, int h,string stroke,int strokewidth, string fill, string scale)
  {
    this.w = w;
    this.h = h;
    this.x = x;
    this.y = y;
    this.stroke = stroke;
    this.fill = fill;
    this.strokewidth = strokewidth;
    this.scale = scale;
  }
  public void ellipses(int x, int y, int rx, int ry,string stroke,int strokewidth, string fill, string scale)
  {
    this.x = x;
    this.y = y;
    this.rx = rx;
    this.ry = ry;
    this.stroke = stroke;
    this.fill = fill;
    this.strokewidth = strokewidth;
    this.scale = scale;
  }
  public void lines(int x, int y, int x2, int y2,string stroke,int strokewidth, string fill, string scale)
  {
    this.x = x;
    this.y = y;
    this.x2 = x2;
    this.y2 = y2;
    this.stroke = stroke;
    this.fill = fill;
    this.strokewidth = strokewidth;
    this.scale = scale;
  }
  public void polylines(int p1, int p2, int p3, int p4, int p5, int p6, int p7, int p8,string stroke,int strokewidth, string fill, string scale)
  {
    this.p1 = p1;
    this.p2 = p2;
    this.p3 = p3;
    this.p4 = p4;
    this.p5 = p5;
    this.p6 = p6;
    this.p7 = p7;
    this.p8 = p8;
    this.stroke = stroke;
    this.fill = fill;
    this.strokewidth = strokewidth;
    this.scale = scale;
  }
  public void polygons(int p1, int p2, int p3, int p4, int p5, int p6, int p7, int p8,string stroke,int strokewidth, string fill, string scale)
  {
    this.p1 = p1;
    this.p2 = p2;
    this.p3 = p3;
    this.p4 = p4;
    this.p5 = p5;
    this.p6 = p6;
    this.p7 = p7;
    this.p8 = p8;
    this.stroke = stroke;
    this.fill = fill;
    this.strokewidth = strokewidth;
    this.scale = scale;
  }
  public void circler(int x, int y, int r,string stroke,int strokewidth, string fill,string rotate)
  {
    this.x = x;
    this.y = y;
    this.r = r;
    this.stroke = stroke;
    this.fill = fill;
    this.strokewidth = strokewidth;
    this.rotate = rotate;
  }
  public void rectangler(int x, int y, int w, int h,string stroke,int strokewidth, string fill, string rotate)
  {
    this.w = w;
    this.h = h;
    this.x = x;
    this.y = y;
    this.stroke = stroke;
    this.fill = fill;
    this.strokewidth = strokewidth;
    this.rotate = rotate;
  }
  public void ellipser(int x, int y, int rx, int ry,string stroke,int strokewidth, string fill, string rotate)
  {
    this.x = x;
    this.y = y;
    this.rx = rx;
    this.ry = ry;
    this.stroke = stroke;
    this.fill = fill;
    this.strokewidth = strokewidth;
    this.rotate = rotate;
  }
  public void liner(int x, int y, int x2, int y2,string stroke,int strokewidth, string fill, string rotate)
  {
    this.x = x;
    this.y = y;
    this.x2 = x2;
    this.y2 = y2;
    this.stroke = stroke;
    this.fill = fill;
    this.strokewidth = strokewidth;
    this.translate = rotate;
  }
  public void polyliner(int p1, int p2, int p3, int p4, int p5, int p6, int p7, int p8,string stroke,int strokewidth, string fill, string rotate)
  {
    this.p1 = p1;
    this.p2 = p2;
    this.p3 = p3;
    this.p4 = p4;
    this.p5 = p5;
    this.p6 = p6;
    this.p7 = p7;
    this.p8 = p8;
    this.stroke = stroke;
    this.fill = fill;
    this.strokewidth = strokewidth;
    this.translate = rotate;
  }
  public void polygonr(int p1, int p2, int p3, int p4, int p5, int p6, int p7, int p8,string stroke,int strokewidth, string fill, string rotate)
  {
    this.p1 = p1;
    this.p2 = p2;
    this.p3 = p3;
    this.p4 = p4;
    this.p5 = p5;
    this.p6 = p6;
    this.p7 = p7;
    this.p8 = p8;
    this.stroke = stroke;
    this.fill = fill;
    this.strokewidth = strokewidth;
    this.rotate = rotate;
  }
  public void circlesk(int x, int y, int r,string stroke,int strokewidth, string fill,string skew)
  {
    this.x = x;
    this.y = y;
    this.r = r;
    this.stroke = stroke;
    this.fill = fill;
    this.strokewidth = strokewidth;
    this.skew = skew;
  }
  public void rectanglesk(int x, int y, int w, int h,string stroke,int strokewidth, string fill, string skew)
  {
    this.w = w;
    this.h = h;
    this.x = x;
    this.y = y;
    this.stroke = stroke;
    this.fill = fill;
    this.strokewidth = strokewidth;
    this.skew = skew;
  }
  public void ellipsesk(int x, int y, int rx, int ry,string stroke,int strokewidth, string fill, string skew)
  {
    this.x = x;
    this.y = y;
    this.rx = rx;
    this.ry = ry;
    this.stroke = stroke;
    this.fill = fill;
    this.strokewidth = strokewidth;
    this.skew = skew;
  }
  public void linesk(int x, int y, int x2, int y2,string stroke,int strokewidth, string fill, string skew)
  {
    this.x = x;
    this.y = y;
    this.x2 = x2;
    this.y2 = y2;
    this.stroke = stroke;
    this.fill = fill;
    this.strokewidth = strokewidth;
    this.skew = skew;
  }
  public void polylinesk(int p1, int p2, int p3, int p4, int p5, int p6, int p7, int p8,string stroke,int strokewidth, string fill, string skew)
  {
    this.p1 = p1;
    this.p2 = p2;
    this.p3 = p3;
    this.p4 = p4;
    this.p5 = p5;
    this.p6 = p6;
    this.p7 = p7;
    this.p8 = p8;
    this.stroke = stroke;
    this.fill = fill;
    this.strokewidth = strokewidth;
    this.skew = skew;
  }
  public void polygonsk(int p1, int p2, int p3, int p4, int p5, int p6, int p7, int p8,string stroke,int strokewidth, string fill, string skew)
  {
    this.p1 = p1;
    this.p2 = p2;
    this.p3 = p3;
    this.p4 = p4;
    this.p5 = p5;
    this.p6 = p6;
    this.p7 = p7;
    this.p8 = p8;
    this.stroke = stroke;
    this.fill = fill;
    this.strokewidth = strokewidth;
    this.skew = skew;
  }
  public void path(int p1, int p2)
  {
    this.p1 = p1;
    this.p2 = p2;
  }
  public void style(string stroke,int strokewidth, string fill)
  {
    this.stroke = stroke;
    this.fill = fill;
    this.strokewidth = strokewidth;
  }

  public void settranslate(string a) { this.translate = a; }
  public void setstroke(string a) { this.stroke = a; }
  public void setstrokewidth(int a) { this.strokewidth = a; }
  public void setfill(string a) { this.fill = a; }
  public void setr(int a) { this.r = a; }
  public void setx(int a) { this.x = a; }
  public void sety(int a) { this.y = a; }
  public void setw(int a) { this.w = a; }
  public void seth(int a) { this.h = a; }
  public void setrx(int a) { this.rx = a; }
  public void setry(int a) { this.ry = a; }
  public void setx2(int a) { this.x2 = a; }
  public void sety2(int a) { this.y2 = a; }
  public void setp1(int a) { this.p1 = a; }
  public void setp2(int a) { this.p2 = a; }
  public void setp3(int a) { this.p3 = a; }
  public void setp4(int a) { this.p4 = a; }
  public void setp5(int a) { this.p5 = a; }
  public void setp6(int a) { this.p6 = a; }
  public void setp7(int a) { this.p7 = a; }
  public void setp8(int a) { this.p8 = a; }
  public string getstroke() { return this.stroke; }
  public int getstrokewidth() { return this.strokewidth; }
  public string getfill() { return this.fill; }
  public int getr() { return this.r; }
  public int getx() { return this.x; }
  public int gety() { return this.y; }
  public int getw() { return this.w; }
  public int geth() { return this.h; }
  public int getrx() { return this.rx; }
  public int getry() { return this.ry; }
  public int getx2() { return this.x2; }
  public int gety2() { return this.y2; }
  public int getp1() { return this.p1; }
  public int getp2() { return this.p2; }
  public int getp3() { return this.p3; }
  public int getp4() { return this.p4; }
  public int getp5() { return this.p5; }
  public int getp6() { return this.p6; }
  public int getp7() { return this.p7; }
  public int getp8() { return this.p8; }
  public string gettranslate() { return this.translate; }

  public string getCircle()
  {
    return "    <circle cx=\"" + this.x + "px" + "\" cy=\"" + this.y + "px" + "\" r=\"" + this.r + "px\"" + " stroke="+"\""+this.stroke+"\""+ " stroke-width=" +"\""+this.strokewidth+"\""+" fill=" +"\""+this.fill+ "\"/>";
  }
  public string getRectangle()
  {
    return "    <rect x=\"" + this.x + "px" + "\" y=\"" + this.y + "px" + "\" width=\"" + this.w + "px" + "\" height=\"" + this.h + "px" + " stroke="+"\""+this.stroke+"\""+ " stroke-width=" +"\""+this.strokewidth+"\""+"fill=" +"\""+this.fill+ "\"/>";
  }
  public string getEllipse()
  {
    return "    <ellipse cx= \"" + this.x + "px\"" + " cy= \"" + this.y + "px\" " + "rx= \"" + this.r + "px\" " + "ry= \"" + this.ry + "px\" " + " stroke="+"\""+this.stroke+"\""+ " stroke-width=" +"\""+this.strokewidth+"\""+" fill=" +"\""+this.fill+"\""+ " />";
  }
  public string getLine()
  {
    return "    <line x1= \"" + this.x + "px\" " + "y1= \"" + this.y + "px\" " + "x2= \"" + this.x2 + "px\" " + "y2= \"" + this.y2 + "px\" " + " stroke="+"\""+this.stroke+"\""+ " stroke-width=" +"\""+this.strokewidth+"\""+" fill=" +"\""+this.fill+"\""+"/>";
  }
  public string getPolyline()
  {
    return "    <polyline points=" + "\"" + this.p1 + "," + this.p2 + " " + this.p3 + "," + this.p4 + " " + this.p5 + "," + this.p6 + " " + this.p7 + "," + this.p8 + "\""+ "stroke="+ " stroke="+"\""+this.stroke+"\""+ " stroke-width=" +"\""+this.strokewidth+"\""+" fill=" +"\""+this.fill+"\""+ "/>";
  }
  public string getPolygon()
  {
    return "    <polygon points=" + "\"" + this.p1 + "," + this.p2 + " " + this.p3 + "," + this.p4 + " " + this.p5 + "," + this.p6 + " " + this.p7 + "," + this.p8 + "\"" + "stroke="+" stroke="+"\""+this.stroke+"\""+ " stroke-width=" +"\""+this.strokewidth+"\""+" fill=" +"\""+this.fill+"\""+ "/>";
  }
  public string getPath()
  {
    return "    <path d=" + "\"M" + this.p1 + " " + this.p2 + "\"" +"/>";
  }
  public string getCircleT()
  {
    return "    <circle cx=\"" + this.x + "px" + "\" cy=\"" + this.y + "px" + "\" r=\"" + this.r + "px" +"\""+ " stroke="+"\""+this.stroke+"\""+ " stroke-width=" +"\""+this.strokewidth+"\""+" fill=" +"\""+this.fill+"\""+" transform="+"\""+"translate("+this.translate+")"+ "\"/>";
  }
  public string getRectangleT()
  {
    return "    <rect x=\"" + this.x + "px" + "\" y=\"" + this.y + "px" + "\" width=\"" + this.w + "px" + "\" height=\"" + this.h + "px" +"\""+ " stroke="+"\""+this.stroke+"\""+ " stroke-width=" +"\""+this.strokewidth+"\""+" fill=" +"\""+this.fill+"\""+" transform="+"\""+"translate("+this.translate+")"+ "\"/>";
  }
  public string getEllipseT()
  {
    return "    <ellipse cx= \"" + this.x + "px\"" + " cy= \"" + this.y + "px\" " + "rx= \"" + this.r + "px\" " + "ry= \"" + this.ry + "px\" " + " stroke="+"\""+this.stroke+"\""+ " stroke-width=" +"\""+this.strokewidth+"\""+" fill=" +"\""+this.fill+"\""+" transform="+"\""+"translate("+this.translate+")"+"\""+ " />";
  }
  public string getLineT()
  {
    return "    <line x1= \"" + this.x + "px\" " + "y1= \"" + this.y + "px\" " + "x2= \"" + this.x2 + "px\" " + "y2= \"" + this.y2 + "px\"" + " stroke="+"\""+this.stroke+"\""+ " stroke-width=" +"\""+this.strokewidth+"\""+" fill="+"\""+this.fill+"\""+" transform="+"\""+"translate("+this.translate+")"+"\""+ "/>";
  }
  public string getPolylineT()
  {
    return "    <polyline points=" + "\"" + this.p1 + "," + this.p2 + " " + this.p3 + "," + this.p4 + " " + this.p5 + "," + this.p6 + " " + this.p7 + "," + this.p8 + "\"" + " stroke="+"\""+this.stroke+"\""+ " stroke-width=" +"\""+this.strokewidth+"\""+" fill=" +"\""+this.fill+"\""+" transform="+"\""+"translate("+this.translate+")"+"\""+ " />";
  }
  public string getPolygonT()
  {
    return "    <polygon points=" + "\"" + this.p1 + "," + this.p2 + " " + this.p3 + "," + this.p4 + " " + this.p5 + "," + this.p6 + " " + this.p7 + "," + this.p8 + "\"" + " stroke="+"\""+this.stroke+"\""+ " stroke-width=" +"\""+this.strokewidth+"\""+" fill=" +"\""+this.fill+"\""+" transform="+"\""+"translate("+this.translate+")"+"\""+" />";
  }
  public string getPathT()
  {
    return "    <path d=" + "\"M" + this.p1 + " " + this.p2 + "\"" + "/>";
  }
  public string getCircleS()
  {
    return "    <circle cx=\"" + this.x + "px" + "\" cy=\"" + this.y + "px" + "\" r=\"" + this.r + "px" +"\""+ " stroke="+"\""+this.stroke+"\""+ " stroke-width=" +"\""+this.strokewidth+"\""+" fill=" +"\""+this.fill+"\""+" transform="+"\""+"scale("+this.scale+")"+ "\"/>";
  }
  public string getRectangleS() 
  {
    return "    <rect x=\"" + this.x + "px" + "\" y=\"" + this.y + "px" + "\" width=\"" + this.w + "px" + "\" height=\"" + this.h + "px" +"\""+ " stroke="+"\""+this.stroke+"\""+ " stroke-width=" +"\""+this.strokewidth+"\""+ " fill=" +"\""+this.fill +"\""+" transform="+"\""+"scale("+this.scale+")"+ "\"/>";
  }
  public string getEllipseS()
  {
    return "    <ellipse cx= \"" + this.x + "px\"" + " cy= \"" + this.y + "px\" " + "rx= \"" + r + "px\" " + "ry= \"" + this.ry + "px\" " + " stroke="+"\""+this.stroke+"\""+ " stroke-width=" + this.strokewidth+ " fill=" +"\""+this.fill+"\""+" transform="+"\""+"scale("+this.scale+")"+"\""+ " />";
  }
  public string getLineS()
  {
    return "    <line x1= \"" + this.x + "px\" " + "y1= \"" + this.y + "px\" " + "x2= \"" + this.x2 + "px\" " + "y2= \"" + this.y2 + "px\"" + " stroke="+"\""+this.stroke+"\""+ " stroke-width=" + this.strokewidth+"\""+" fill=" +"\""+ this.fill+"\""+" transform="+"\""+"scale("+this.scale+")"+"\""+ "/>";
  }
  public string getPolylineS()
  {
    return "    <polyline points=" + "\"" + this.p1 + "," + this.p2 + " " + this.p3 + "," + this.p4 + " " + this.p5 + "," + this.p6 + " " + this.p7 + "," + this.p8 + "\"" + " stroke="+"\""+this.stroke+"\""+ " stroke-width=" +"\""+ this.strokewidth+"\""+" fill=" +"\""+ this.fill+"\""+" transform="+"\""+"scale("+this.scale+")"+"\""+ " />";
  }
  public string getPolygonS()
  {
    return "    <polygon points=" + "\"" + this.p1 + "," + this.p2 + " " + this.p3 + "," + this.p4 + " " + this.p5 + "," + this.p6 + " " + this.p7 + "," + this.p8 + "\"" + " stroke="+"\""+this.stroke+"\""+ " stroke-width=" +"\""+ this.strokewidth+"\""+" fill=" +"\""+ this.fill+"\""+" transform="+"\""+"scale("+this.scale+")"+"\""+ " />";
  }
  public string getPathS()
  {
    return "    <path d=" + "\"M" + this.p1 + " " + this.p2 + "\"" + "/>";
  }
  public string getCircleR()
  {
    return "    <circle cx=\"" + this.x + "px" + "\" cy=\"" + this.y + "px" + "\" r=\"" + this.r + "px" +"\""+ " stroke="+ "\""+this.stroke +"\""+ " stroke-width=" +"\""+this.strokewidth+"\""+ " fill=" + "\""+this.fill+"\""+" transform="+"\""+"rotate("+this.rotate+")"+ "\"/>";
  }
  public string getRectangleR()
  {
    return "    <rect x=\"" + this.x + "px" + "\" y=\"" + this.y + "px" + "\" width=\"" + this.w + "px" + "\" height=\"" + this.h + "px" +"\""+ " stroke="+ "\""+this.stroke +"\""+ " stroke-width=" + "\""+this.strokewidth+"\""+ " fill=" + "\""+this.fill+"\""+" transform="+"\""+"rotate("+this.rotate+")"+ "\"/>";
  }
  public string getEllipseR()
  {
    return "    <ellipse cx= \"" + this.x + "px\"" + " cy= \"" + this.y + "px\" " + "rx= \"" + this.r + "px\" " + "ry= \"" + this.ry + "px\" "+ " stroke="+ "\""+this.stroke +"\""+ " stroke-width=" + "\""+this.strokewidth+"\""+ " fill=" + "\""+this.fill+"\""+" transform="+"\""+"rotate("+this.rotate+")"+"\""+ " />";
  }
  public string getLineR()
  {
    return "    <line x1= \"" + this.x + "px\" " + "y1= \"" + this.y + "px\" " + "x2= \"" + this.x2 + "px\" " + "y2= \"" + this.y2 + "px\"" + " stroke="+ "\""+this.stroke +"\""+ " stroke-width=" + "\""+this.strokewidth+"\""+ " fill=" + "\""+this.fill+"\""+" transform="+"\""+"rotate("+this.rotate+")"+"\""+ "/>";
  }
  public string getPolylineR()
  {
    return "    <polyline points=" + "\"" + this.p1 + "," + this.p2 + " " + this.p3 + "," + this.p4 + " " + this.p5 + "," + this.p6 + " " + this.p7 + "," + this.p8 + "\"" + " stroke="+ "\""+this.stroke+"\"" + " stroke-width=" + "\""+this.strokewidth+"\""+ " fill=" + "\""+this.fill+"\""+" transform="+"\""+"rotate("+this.rotate+")"+"\""+ " />";
  }
  public string getPolygonR()
  {
    return "    <polygon points=" + "\"" + this.p1 + "," + this.p2 + " " + this.p3 + "," + this.p4 + " " + this.p5 + "," + this.p6 + " " + this.p7 + "," + this.p8 + "\"" + " stroke="+ "\""+this.stroke+"\"" + " stroke-width=" + "\""+this.strokewidth+"\""+ " fill=" + "\""+this.fill+"\""+" transform="+"\""+"rotate("+this.rotate+")"+"\""+ " />";
  }
  public string getCircleSK()
  {
    return "    <circle cx=\"" + this.x + "px" + "\" cy=\"" + this.y + "px" + "\" r=\"" + this.r + "px" +"\""+ " stroke="+"\""+this.stroke+"\""+ " stroke-width=" +"\""+this.strokewidth+"\""+ " fill=" +"\""+this.fill+"\""+" transform="+"\""+"skew("+this.skew+")"+ "\"/>";
  }
  public string getRectangleSK()
  {
    return "    <rect x=\"" + this.x + "px" + "\" y=\"" + this.y + "px" + "\" width=\"" + this.w + "px" + "\" height=\"" + this.h + "px" +"\""+ " stroke="+"\""+this.stroke+"\""+ " stroke-width=" +"\""+this.strokewidth+"\""+ " fill=" +"\""+this.fill+"\""+" transform="+"\""+"skew("+this.skew+")"+ "\"/>";
  }
  public string getEllipseSK()
  {
    return "    <ellipse cx= \"" + this.x + "px\"" + " cy= \"" + this.y + "px\" " + "rx= \"" + this.r + "px\" " + "ry= \"" + this.ry + "px\" "+ " stroke="+"\""+this.stroke+"\""+ " stroke-width=" +"\""+this.strokewidth+"\""+" fill=" +"\""+this.fill+"\""+" transform="+"\""+"skew("+this.skew+")"+"\""+ " />";
  }
  public string getLineSK()
  {
    return "    <line x1= \"" + this.x + "px\" " + "y1= \"" + this.y + "px\" " + "x2= \"" + this.x2 + "px\" " + "y2= \"" + this.y2 + "px\"" + " stroke="+"\""+this.stroke+"\""+ " stroke-width=" +"\""+this.strokewidth+"\""+ " fill=" +"\""+this.fill+"\""+" transform="+"\""+"skew("+this.skew+")"+"\""+ "/>";
  }
  public string getPolylineSK()
  {
    return "    <polyline points=" + "\"" + this.p1 + "," + this.p2 + " " + this.p3 + "," + this.p4 + " " + this.p5 + "," + this.p6 + " " + this.p7 + "," + this.p8 + "\"" + " stroke="+"\""+this.stroke +"\""+ " stroke-width=" +"\""+this.strokewidth+"\""+ " fill=" +"\""+this.fill+"\""+" transform="+"\""+"skew("+this.skew+")"+"\""+ " />";
  }
  public string getPolygonSK()
  {
    return "    <polygon points=" + "\"" + this.p1 + "," + this.p2 + " " + this.p3 + "," + this.p4 + " " + this.p5 + "," + this.p6 + " " + this.p7 + "," + this.p8 + "\"" + " stroke="+"\""+this.stroke +"\""+ " stroke-width=" +"\""+this.strokewidth+"\""+ " fill=" +"\""+this.fill+"\""+" transform="+"\""+"skew("+this.skew+")"+"\""+ " />";
  }

  public string getStyle()
  {
    return "      "+"fill: "+fill+";"+"\n"+"      "+"stroke: "+stroke+";"+"\n"+"      "+"stroke-width: "+strokewidth+"px;"+"\n"+"     }";
  }

}