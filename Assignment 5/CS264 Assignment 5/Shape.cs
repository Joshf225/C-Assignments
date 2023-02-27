namespace Assignment5;
//This class calls the Shapes class I created where I have all the details for each shape and then uses the shape factory class to find and call the shape it wants
//it then adds it to its shape equivelent variable by calling the getShape method from the Shapes class to add the shape to the variable and returns it

//For this Assignment I kind of merged the factory method with the method I used for my shape classes in the other Assignments to make it easier to implement 
//instead of creating it all over again 
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
    Shapes shape = ShapeFactory.GetShapes("circle");
    string circle = shape.getShape();
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
public class Circlet : Shape
{


  public Circlet()
  {

  }

  public override string ToString()
  {
    Shapes shape = ShapeFactory.GetShapes("circle");
    string circle = shape.getShape();
    return circle;
  }
}
public class Rectanglet : Shape
{


  public Rectanglet()
  {

  }

  public override string ToString()
  {
    Shapes shape = ShapeFactory.GetShapes("rectangle");
    string rectangle = shape.getShape();
    return rectangle;
  }
}

public class Ellipset : Shape
{


  public Ellipset()
  {

  }

  public override string ToString()
  {
    Shapes shape = ShapeFactory.GetShapes("ellipse");
    string ellipse = shape.getShape();
    return ellipse;
  }
}

public class Linet : Shape
{


  public Linet()
  {

  }

  public override string ToString()
  {
    Shapes shape = ShapeFactory.GetShapes("line");
    string line = shape.getShape();
    return line;
  }
}

public class Polylinet : Shape
{


  public Polylinet()
  {

  }

  public override string ToString()
  {
    Shapes shape = ShapeFactory.GetShapes("polyline");
    string polyline = shape.getShape();
    return polyline;
  }
}

public class Polygont : Shape
{


  public Polygont()
  {

  }

  public override string ToString()
  {
    Shapes shape = ShapeFactory.GetShapes("polygon");
    string polygon = shape.getShape();
    return polygon;
  }
}
public class Patht : Shape
{


  public Patht()
  {

  }

  public override string ToString()
  {
    Shapes shape = ShapeFactory.GetShapes("path");
    string path = shape.getShape();
    return path;
  }
}