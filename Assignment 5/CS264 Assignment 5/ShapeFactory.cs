namespace Assignment5;

//Factory class
class ShapeFactory
{
  public static Shapes GetShapes(string shapeType)
  {
    Shapes shape = null;
    Shapes sh = null;
    if (shapeType == "circle")
    {
  
      shape = new Circle();
    }
    else if (shapeType == "rectangle")
    {
      shape = new Rectangle();
    }
    else if (shapeType == "ellipse")
    {
      shape = new Ellipse();
    }
    else if (shapeType == "line")
    {
      shape = new Line();
    }
    else if (shapeType == "polyline")
    {
      shape = new Polyline();
    }
    else if (shapeType == "polygon")
    {
      shape = new Polygon();
    }
    return shape;
  }
}