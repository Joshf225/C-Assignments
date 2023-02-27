namespace Assignment5;

//Product Interface and Classes
public interface Shapes
{
  string getShape();

}

class Circle : Shapes
{
  private string fill;
  private string stroke;
  private string name;

  public void style(string stroke, string fill, string name)
  {
    this.stroke = stroke;
    this.fill = fill;
    this.name = name;
  }

  public string getShape()
  {
    Random rnd = new Random();
    return "  <circle cx=" + "\"" + rnd.Next(1, 100) + "\"" + " cy=" + "\"" + rnd.Next(1, 100) + "\"" + " r=" + "\"" + rnd.Next(1, 100) + "\"" + " stroke= " + "\"" + this.stroke + "\"" + " stroke-width=" + "\"" + rnd.Next(1, 3) + "\"" + " fill= " + "\"" + this.fill + "\"" + " />";
  }


}
class Rectangle : Shapes
{
  private string fill;
  private string stroke;
  private string name;

  public void style(string stroke, string fill, string name)
  {
    this.stroke = stroke;
    this.fill = fill;
    this.name = name;
  }

  Random rnd = new Random();
  public string getShape()
  {
    return "  <rect width=" + "\"" + rnd.Next(50, 300) + "\"" + " height=" + "\"" + rnd.Next(50, 300) + "\"" + " style=\"fill:" + this.fill + ";stroke-width:" + rnd.Next(1, 3) + "stroke:" + this.stroke + "\"" + " />";
  }
}
class Ellipse : Shapes
{
  private string fill;
  private string stroke;
  private string name;

  public void style(string stroke, string fill, string name)
  {
    this.stroke = stroke;
    this.fill = fill;
    this.name = name;
  }
  Random rnd = new Random();
  public string getShape()
  {
    return "  <ellipse cx=" + "\"" + rnd.Next(50, 200) + "\"" + " cy=" + "\"" + rnd.Next(50, 200) + "\"" + " rx=" + "\"" + rnd.Next(50, 200) + "\"" + " ry=" + "\"" + rnd.Next(50, 200) + "\"" + " style=\" fill:" + this.fill + ";stroke:" + this.stroke + ";stroke-width:2\" />";
  }
}
class Line : Shapes
{
  private string fill;
  private string stroke;
  private string name;

  public void style(string stroke, string fill, string name)
  {
    this.stroke = stroke;
    this.fill = fill;
    this.name = name;
  }
  Random rnd = new Random();
  public string getShape()
  {
    return "  <line x1=" + "\"" + rnd.Next(50, 300) + "\"" + " y1=" + "\"" + rnd.Next(50, 300) + "\"" + " x2=" + "\"" + rnd.Next(50, 300) + "\"" + " y2=" + "\"" + rnd.Next(50, 300) + "\"" + " stroke=" + this.stroke + " />";
  }
}
class Polyline : Shapes
{
  private string fill;
  private string stroke;
  private string name;

  public void style(string stroke, string fill, string name)
  {
    this.stroke = stroke;
    this.fill = fill;
    this.name = name;
  }
  Random rnd = new Random();
  public string getShape()
  {
    return "  <polyline points=" + "\"" + rnd.Next(20, 100) + "," + rnd.Next(20, 100) + " " + rnd.Next(20, 100) + "," + rnd.Next(20, 100) + " " + rnd.Next(20, 100) + "," + rnd.Next(20, 100) + " " + rnd.Next(20, 100) + "," + rnd.Next(20, 100) + "\" fill=" + "\"" + this.fill + "\"" + " stroke=" + "\"" + this.stroke + "\"" + " />";
  }
}
class Polygon : Shapes
{
  private string fill;
  private string stroke;
  private string name;

  public void style(string stroke, string fill, string name)
  {
    this.stroke = stroke;
    this.fill = fill;
    this.name = name;
  }

  Random rnd = new Random();
  public string getShape()
  {
    return "  <polygon points=" + "\"" + rnd.Next(20, 100) + "," + rnd.Next(20, 100) + " " + rnd.Next(20, 100) + "," + rnd.Next(20, 100) + " " + rnd.Next(20, 100) + "," + rnd.Next(20, 100) + " " + rnd.Next(20, 100) + "," + rnd.Next(20, 100) + "\" fill="+this.fill+" stroke="+this.stroke+" />";
  }
}