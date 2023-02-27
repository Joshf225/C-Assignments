namespace Assignment4;

public abstract class Shape
{
  public Random rnd = new Random();
  public override string ToString()
  {
    return "Shape!";
  }
}
public class Start : Shape
{
  public Start()
  {

  }

  public override string ToString()
  {
    return "<svg viewBox=\"0 0 500 500\" xmlns=\"http://www.w3.org/2000/svg\">";
  }
}
public class End : Shape
{
  public End()
  {

  }

  public override string ToString()
  {
    return "</svg>";
  }
}
public class Empty : Shape
{
  public Empty()
  {

  }

  public override string ToString()
  {
    return "";
  }
}
public class Circle : Shape
{


  public Circle()
  {

  }

  public override string ToString()
  {
    return "  <circle cx=" + "\"" + rnd.Next(1, 100) + "\"" + " cy=" + "\"" + rnd.Next(1, 100) + "\"" + " r=" + "\"" + rnd.Next(1, 100) + "\"" + " stroke=\"black\" stroke-width=" + "\"" + rnd.Next(1, 3) + "\"" + " fill=\"red\" />";
  }
}
public class Rectangle : Shape
{


  public Rectangle()
  {

  }

  public override string ToString()
  {
    return "  <rect width=" + "\"" + rnd.Next(50, 300) + "\"" + " height=" + "\"" + rnd.Next(50, 300) + "\"" + " style=\"fill:rgb(0,0,255);stroke-width:" + rnd.Next(1, 3) + "stroke:rgb(0,0,0)\" />";
  }
}

public class Ellipse : Shape
{


  public Ellipse()
  {

  }

  public override string ToString()
  {
    return "  <ellipse cx=" + "\"" + rnd.Next(50, 200) + "\"" + " cy=" + "\"" + rnd.Next(50, 200) + "\"" + " rx=" + "\"" + rnd.Next(50, 200) + "\"" + " ry=" + "\"" + rnd.Next(50, 200) + "\"" + " style=\" fill:yellow;stroke:purple;stroke-width:2\" />";
  }
}

public class Line : Shape
{


  public Line()
  {

  }

  public override string ToString()
  {
    return "  <line x1=" + "\"" + rnd.Next(50, 300) + "\"" + " y1=" + "\"" + rnd.Next(50, 300) + "\"" + " x2=" + "\"" + rnd.Next(50, 300) + "\"" + " y2=" + "\"" + rnd.Next(50, 300) + "\"" + " stroke=\"black\" />";
  }
}

public class Polyline : Shape
{


  public Polyline()
  {

  }

  public override string ToString()
  {
    return "  <polyline points=" + "\"" + rnd.Next(20, 100) + "," + rnd.Next(20, 100) + " " + rnd.Next(20, 100) + "," + rnd.Next(20, 100) + " " + rnd.Next(20, 100) + "," + rnd.Next(20, 100) + " " + rnd.Next(20, 100) + "," + rnd.Next(20, 100) + "\" fill=\"red\" stroke=\"black\" />";
  }
}

public class Polygon : Shape
{


  public Polygon()
  {

  }

  public override string ToString()
  {
    return "  <polygon points=" + "\"" + rnd.Next(20, 100) + "," + rnd.Next(20, 100) + " " + rnd.Next(20, 100) + "," + rnd.Next(20, 100) + " " + rnd.Next(20, 100) + "," + rnd.Next(20, 100) + " " + rnd.Next(20, 100) + "," + rnd.Next(20, 100) + "\" fill=\"blue\" stroke=\"black\" />";
  }
}