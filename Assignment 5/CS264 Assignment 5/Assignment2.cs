namespace Assignment5;

public class ShapefromA2
{
  Random rnd = new Random();
  private string stroke;
  private string fill;
  private int index;
  private string name;
  public void style(string stroke, string fill, int index, string name)
  {
    this.stroke = stroke;
    this.fill = fill;
    this.index = index;
    this.name = name;
  }

  public void setStroke(string x) { this.stroke = x; }
  public void setFill(string x) { this.fill = x; }
  public int getIndex() { return this.index; }
  public string getName() { return this.name; }

  public string getRectangle()
  {
    return "    <rect x=\"" + rnd.Next(50, 300) + "px" + "\" y=\"" + rnd.Next(50, 300) + "px" + "\" width=\"" + rnd.Next(50, 300) + "px" + "\" height=\"" + rnd.Next(50, 300) + "px" + "\" fill=\"" + this.fill + "\" stroke=\"" + this.stroke + "\" stroke-width=\"" + rnd.Next(0, 5) + "px" + "\"/>";
  }
  public string getCircle()
  {
    return "    <circle cx=\"" + rnd.Next(50, 300) + "px" + "\" cy=\"" + rnd.Next(50, 300) + "px" + "\" r=\"" + rnd.Next(50, 300) + "px" + "\" fill=\"" + this.fill + "\" stroke=\"" + this.stroke + "\" stroke-width=\"" + rnd.Next(0, 5) + "px" + "\"/>";
  }
  public string getEllipse()
  {
    return "    <ellipse cx= \"" + rnd.Next(50, 300) + "px\"" + " cy= \"" + rnd.Next(50, 300) + "px\" " + "rx= \"" + rnd.Next(50, 300) + "px\" " + "ry= \"" + rnd.Next(50, 300) + "px\" " + "style=" + "\"fill:" + this.fill + "\"" + " stroke-width=\"" + rnd.Next(0, 5) + "px" + "\"" + " />";
  }
  public string getLine()
  {
    return "    <line x1= \"" + rnd.Next(50, 300) + "px\" " + "y1= \"" + rnd.Next(50, 300) + "px\" " + "x2= \"" + rnd.Next(50, 300) + "px\" " + "y2= \"" + rnd.Next(50, 300) + "px\" " + "stroke= " + "\"" + this.stroke + "\" " + "stroke-width= " + "\"" + rnd.Next(0, 5) + "px\" " + "/>";
  }
  public string getPolyline()
  {
    return "    <polyline points=" + "\"" + rnd.Next(50, 300) + "," + rnd.Next(50, 300) + " " + rnd.Next(50, 300) + "," + rnd.Next(50, 300) + " " + rnd.Next(50, 300) + "," + rnd.Next(50, 300) + " " + rnd.Next(50, 300) + "," + rnd.Next(50, 300) + "\"" + " stroke-width=\"" + rnd.Next(50, 300) + " \"" + "style=" + "\"fill:" + this.fill + "\" stroke=\"" + this.stroke + " />";
  }
  public string getPolygon()
  {
    return "    <polygon points=" + "\"" + rnd.Next(50, 300) + "," + rnd.Next(50, 300) + " " + rnd.Next(50, 300) + "," + rnd.Next(50, 300) + " " + rnd.Next(50, 300) + "," + rnd.Next(50, 300) + " " + rnd.Next(50, 300) + "," + rnd.Next(50, 300) + "\"" + " stroke-width=\"" + rnd.Next(50, 300) + "\"" + " \"" + "style=" + "\"fill:" + this.fill + "\" stroke=\"" + this.stroke + " />";
  }
  public string getPath()
  {
    return "    <path d=" + "\"M" + rnd.Next(50, 300) + " " + rnd.Next(50, 300) + "\"" + " stroke-width=\"" + rnd.Next(50, 300) + "\"" + "/>";
  }
}